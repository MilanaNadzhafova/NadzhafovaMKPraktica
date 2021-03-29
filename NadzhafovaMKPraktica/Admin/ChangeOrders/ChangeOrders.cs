using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace NadzhafovaMKPraktica
{

    public partial class ChangeOrders : Form
    {
        int OrderID;
        string Email, Status, Addres;
        public ChangeOrders(int ID, string Pay, string Stat, string IDStatus, string Pharm, string Mail, string Adress) //Передача данных с предыдущей формы (Orders)
        {
            InitializeComponent();
            OrderID = ID;
            txtMethod.Text = Pay;
            txtPharmacies.Text = Pharm;
            Email = Mail;
            Status = Stat;
            Addres = Adress;
        }

        private void picClose_Click(object sender, EventArgs e) //Закрытие формы и переход на предыдующую (Orders)
        {
            this.Close();
            GC.Collect();
            Orders orders = new Orders();
            orders.Visible = true;
            orders.ShowInTaskbar = true;
        }

        private void ChangeOrders_Load(object sender, EventArgs e) // Отображение таблицы с содержимым заказа при прогрузке формы
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmPanaceyaDataSet.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.pharmPanaceyaDataSet.Status);
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                string query = "SELECT m.Name, bc.Amount, bc.Price " +
 "FROM Orders as ord INNER JOIN Baskets as b ON ord.IDBasket = b.IDBasket INNER JOIN BasketConsist as bc ON b.IDBasket = bc.IDBasket " +
 "INNER JOIN Medicines as m ON bc.IDMedicines = m.IDMedicine WHERE ord.IDOrder = @ID";

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"ID", OrderID);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    tableConsist.DataSource = dt;
                    tableConsist.Update();
                    tableConsist.Columns[0].Width = 70;
                    tableConsist.Columns[1].Width = 70;
                    tableConsist.Columns[2].Width = 80;


                    tableConsist.Columns[0].HeaderText = "Лекарства";
                    tableConsist.Columns[1].HeaderText = "Количество";
                    tableConsist.Columns[2].HeaderText = "Цена";



                    tableConsist.Refresh();
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
        private static async Task SendEmailAsync(string Email, string Status,string Pharm, string Adress) //Метод для отправки письма об изменении статуса заказа на почту
        { 
            MailAddress from = new MailAddress("mnadgafova47@gmail.com", "online-apteka 'Panaceya'");
            MailAddress to = new MailAddress(Email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Статус вашего заказа изменен";
            if(Status =="Ожидает получения")
            {
                m.Body = $"Ваш заказ ожидает получения в аптеке '{Pharm}' по адресу {Adress}";
            }
            else
            {
                m.Body = $"Здравствуйте, статус вашего заказа '{Status}'";
            }
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("mnadgafova47@gmail.com", "3211q1q1q");
            await smtp.SendMailAsync(m);

        }

        private void btnChange_Click(object sender, EventArgs e) //Изменение статуса заказа в базе данных при нажатии на кнопку изменить статус заказа
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE [Orders] SET IDStatus = @Status  WHERE  IDBasket  = @IDBasket";


                    cmd.Parameters.AddWithValue(@"IDBasket", OrderID);
                    cmd.Parameters.AddWithValue(@"Status", comboStatus.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно изменена!");
                    Status = comboStatus.Text;
                    Orders order = new Orders();
                    order.Show();
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
            SendEmailAsync(Email, Status, txtPharmacies.Text, Addres).GetAwaiter();
            Console.Read();
        }
    }
}
