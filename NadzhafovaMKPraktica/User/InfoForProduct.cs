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

namespace NadzhafovaMKPraktica
{
    public partial class InfoForProduct : Form
    {
        int ID, IDCateg;
        public InfoForProduct(Image img, int Id) //Передача значений с предыдущих форм с товарами
        {
            InitializeComponent();
            pcImage.Image = img;
            ID = Id;
            LoadInfo();
        }
        public void LoadInfo() //Метод для вывода инфомрации о товаре на форму
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT Name, Description, Price, Presence, IDCategory FROM [Medicines] WHERE IDMedicine = @ID  ";
                    cmd.Parameters.AddWithValue(@"ID", ID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    txtName.Text = reader.GetValue(0).ToString();
                    txtDescription.Text = reader.GetValue(1).ToString();
                    txtPrice.Text = Convert.ToInt32(reader.GetValue(2)).ToString();
                    IDCateg = Convert.ToInt32(reader.GetValue(4));
                    if (Convert.ToBoolean(reader.GetValue(3)))
                    {
                        txtPresence.Text = "В наличии";
                    }
                    else
                    {
                        txtPresence.Text = "Не в наличии";
                        txtAmount.ReadOnly= true;
                    }
                    reader.Close();
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

        private void txtAmount_TextChanged(object sender, EventArgs e) // Метод для преесчета стоимости при изменении количества товаров
        {
            if (txtAmount.Text != string.Empty)
            {
                if (txtAmount.Text != "0")
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                    {

                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "SELECT Amount FROM [Medicines] WHERE IDMedicine = @ID  ";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            int amountOnSklad = Convert.ToInt32(cmd.ExecuteScalar());
                            int amountOnCorzina = Convert.ToInt32(txtAmount.Text);
                            if (amountOnCorzina > amountOnSklad)
                            {
                                txtAmount.Text = amountOnSklad.ToString();
                                MessageBox.Show("На складе отсутствует такое количество товаров, попробуйте ввести значение поменьше!");
                            }
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
                else
                {
                    MessageBox.Show("Выберите хотя бы одну единицу товара");
                    txtAmount.Text = "1";
                }
            }
           
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e) // Запрет на ввод в поле чего-то, кроме цифр
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void InfoForProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOnBasket_Click(object sender, EventArgs e) // Добавление записи в BasketConsist при добавлении товара в корзину
        {
            if (txtPresence.Text == "В наличии")
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO [BasketConsist] VALUES (@IDBasket,@IDMedicines,@Amount,@Price)";
                        cmd.Parameters.AddWithValue(@"IDBasket", Autorization.userID.IDBasket);
                        cmd.Parameters.AddWithValue(@"IDMedicines", ID);
                        cmd.Parameters.AddWithValue(@"Amount", txtAmount.Text);
                        int priceOfClient = Convert.ToInt32(txtPrice.Text);
                        int amountOfClient = Convert.ToInt32(txtAmount.Text);
                        int totalPrice = priceOfClient * amountOfClient;
                        cmd.Parameters.AddWithValue(@"Price", totalPrice.ToString());
                        cmd.ExecuteNonQuery();
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
            else
            {
                MessageBox.Show("Товара, к сожалению нет в наличии, дождемся его поступления!!");

            }
        }
       
        // Переход на предыдущую форму, в зависимости от того, на какой именно категории находится пользователь
        private void picClose_Click(object sender, EventArgs e) 
        {
            if (IDCateg == 2)
            {
                this.Close();
                GC.Collect();
                Diabetes diabetes = new Diabetes();
                diabetes.Visible = true;
                diabetes.ShowInTaskbar = true;
            }
            else if (IDCateg == 3)
            {
                this.Close();
                GC.Collect();
                Vision vision = new Vision();
                vision.Visible = true;
                vision.ShowInTaskbar = true;
            }
            else if(IDCateg == 4)
            {
                this.Close();
                GC.Collect();
                Joints joints = new Joints();
                joints.Visible = true;
                joints.ShowInTaskbar = true;
            }
            else
            {
                this.Close();
                GC.Collect();
                Hygiene hygiene = new Hygiene();
                hygiene.Visible = true;
                hygiene.ShowInTaskbar = true;
            }
        }
    }
}
