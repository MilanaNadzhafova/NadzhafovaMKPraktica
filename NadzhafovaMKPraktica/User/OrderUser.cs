using iText.IO.Font;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Font;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadzhafovaMKPraktica
{
    public partial class OrderUser : Form
    {
        string Price;
        public OrderUser(string allPrice) //Передача значения общей стоимости заказа с предыдущей формы (Basket)
        {
            InitializeComponent();
            UpdateOrders();
            UpdateCmbBox();
            Price = allPrice;
            
        }

        private void OrderUser_Load(object sender, EventArgs e) 
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmPanaceyaDataSet.PayMethod". При необходимости она может быть перемещена или удалена.
            this.payMethodTableAdapter.Fill(this.pharmPanaceyaDataSet.PayMethod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmPanaceyaDataSet.Pharmacies". При необходимости она может быть перемещена или удалена.
            this.pharmaciesTableAdapter.Fill(this.pharmPanaceyaDataSet.Pharmacies);

        }
        private void UpdateOrders() // Метод на вывод содержания корзины на форму
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                string query = "SELECT m.Name, b.[Amount], b.[Price] FROM [BasketConsist] AS b INNER JOIN Medicines AS m ON b.IDMedicines = m.IDMedicine WHERE IDBasket = @IdBasket";

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"IdBasket", Autorization.userID.IDBasket);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    tableConsist.DataSource = dt;
                    tableConsist.Update();
                    tableConsist.Columns[0].HeaderText = "Лекарства";
                    tableConsist.Columns[1].HeaderText = "Количество";
                    tableConsist.Columns[2].HeaderText = "Цена";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }

            }
        }
        private void UpdateCmbBox() // Метод для подстановки адресов точек выдачи в ComboBox
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                string query = "SELECT IDPharm, Address FROM [Pharmacies]  ";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    comboAddress.DataSource = dt;
                    comboAddress.DisplayMember = "Address";
                    comboAddress.ValueMember = "IDPharm";
                    comboAddress.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }

            }
        }
        private static async Task SendEmailAsync(string Email) // Метод для отправки сообщения и PDF-файла с содержимым заказа на почту клиенту
        {
            MailAddress from = new MailAddress("mnadgafova47@gmail.com", "online-apteka 'Panaceya'");
            MailAddress to = new MailAddress(Email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Ваш заказ оформлен";
            m.Body = $"Ваш заказ оформлен, как только он будет готов, вам придет сообщение!";
            m.Attachments.Add(new Attachment("C:\\Users\\mnadg\\Desktop\\Consist.pdf"));
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("mnadgafova47@gmail.com", "3211q1q1q");
            await smtp.SendMailAsync(m);
        }
        private void DeleteNote() // Метод для удаления товаров заказа из корзины при оформлении заказа
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM [BasketConsist] WHERE IDBasket = @ID";
                    cmd.Parameters.AddWithValue(@"ID", Autorization.userID.IDBasket);
                    cmd.ExecuteScalar();
                }

                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnAddOnOrders_Click(object sender, EventArgs e) //Нажатие на кнопку оформить заказ и вызов всех необходимых методов
        {
            PDFCreate();
            OrderAdd();
            DeleteNote();
            SendEmailAsync(Autorization.userID.Email).GetAwaiter();
            Console.Read();

        }
        private void PDFCreate() // Метод для формирования PDF-фвйла с содержимым заказа
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                string query = "SELECT m.Name, b.[Amount], b.[Price] FROM [BasketConsist] AS b INNER JOIN Medicines AS m ON b.IDMedicines = m.IDMedicine WHERE IDBasket = @IdBasket";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue(@"IdBasket", Autorization.userID.IDBasket);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tableConsist = new DataTable();
                    tableConsist.Load(reader);
                    string dest = "C:\\Users\\mnadg\\Desktop\\Consist.pdf";
                    PdfWriter writer = new PdfWriter(dest);
                    PdfDocument pdfDoc = new PdfDocument(writer);
                    Document document = new Document(pdfDoc);
                    Table table = new Table(tableConsist.Columns.Count);
                    PdfFont russian = PdfFontFactory.CreateFont("c:/Windows/Fonts/Arial.ttf", "CP1251", true);
                    document.SetFont(russian);
                    table.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    table.SetFontColor(new DeviceRgb(0, 0, 0));
                    iText.Kernel.Colors.Color color = new DeviceRgb(255, 178, 204);
                    CreateCell(table, "Название", 200, color);
                    CreateCell(table, "Количество", 100, color);
                    CreateCell(table, "Цена, руб", 100, color);

                    for (int i = 0; i < tableConsist.Rows.Count; i++)
                    {
                        for (int j = 0; j < tableConsist.Columns.Count; j++)
                        {
                            Cell cell = new Cell();
                            if (j == 2) cell.Add(new Paragraph(Convert.ToInt32(tableConsist.Rows[i][j]).ToString()));
                            
                            else cell.Add(new Paragraph(tableConsist.Rows[i][j].ToString()));
                            cell.SetBackgroundColor(new DeviceRgb(255, 231, 244));
                            cell.SetFontSize(7);
                            table.AddCell(cell);
                        }
                    }
                    iText.Layout.Element.Paragraph price =  new Paragraph("Итого: "+" " + Price);
                    document.Add(table);
                    document.Add(price);
                    document.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void OrderAdd() // Добавление записи о заказе в базу данных
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                try
                {

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO [Orders] VALUES (@IDStatus,@IDPay,@IDPharm,@IDBasket)";
                    cmd.Parameters.AddWithValue(@"IDStatus", 1);
                    cmd.Parameters.AddWithValue(@"IDPay", comboPay.SelectedValue);
                    cmd.Parameters.AddWithValue(@"IDPharm", comboAddress.SelectedValue);
                    cmd.Parameters.AddWithValue(@"IDBasket", Autorization.userID.IDBasket);
                    cmd.ExecuteNonQuery();
                    string query = "SELECT IDMedicines, Amount from BasketConsist where IDBasket = @ID ";
                    SqlCommand cmd2 = new SqlCommand(query, conn);
                    cmd2.Parameters.AddWithValue(@"ID", Autorization.userID.IDBasket);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    //Пересчет количества товаров в БД
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        string query2 = "Select Amount From Medicines where IDMedicine = @ID";
                        SqlCommand cmd3 = new SqlCommand(query2, conn);
                        cmd3.Parameters.AddWithValue(@"ID", dataTable.Rows[i][0]);
                        int amount = Convert.ToInt32(cmd3.ExecuteScalar());
                        amount -= Convert.ToInt32(dataTable.Rows[i][1]);

                       if(amount == 0)
                        {
                            //Если при пересчете количество будет равно нулю, то наличие соответственно становится НЕ В НАЛИЧИИ
                            string query4 = "Update Medicines set Presence = @Presence where IDMedicine = @ID";
                            SqlCommand cmd5 = new SqlCommand(query4, conn);
                            cmd5.Parameters.AddWithValue(@"ID", dataTable.Rows[i][0]);
                            cmd5.Parameters.AddWithValue(@"Presence", 0);
                            cmd5.ExecuteNonQuery();
                        }

                        string query3 = "Update Medicines set Amount = @Amount where IDMedicine = @ID";
                        SqlCommand cmd4 = new SqlCommand(query3, conn);
                        cmd4.Parameters.AddWithValue(@"ID", dataTable.Rows[i][0]);
                        cmd4.Parameters.AddWithValue(@"Amount", amount);
                        cmd4.ExecuteNonQuery();
                    }
                    Catalog catalog = new Catalog();
                    catalog.Show();
                    this.Hide();
                    GC.Collect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }

            }
        }
       
        //Метод для определения стиля столбцов/строк в таблице в PDF-файле
        private void CreateCell(Table table, string str, float widthCell, iText.Kernel.Colors.Color bgColor) 
        {
            Cell cell1 = new Cell();
            cell1.Add(new Paragraph(str));
            cell1.SetWidth(widthCell);
            cell1.SetFontSize(10);
            cell1.SetBackgroundColor(bgColor);
            table.AddCell(cell1);
        }

        private void picClose_Click(object sender, EventArgs e) //Переход на форму с корзиной
        {
            this.Hide();
            Basket basket = new Basket();
            basket.Show();
        }

        private void comboPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            picClose.Focus();
        }

        private void comboAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            picClose.Focus();
        }
    }
}
