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

    public partial class ChangeMedicines : Form
    {
        int MedId;
        public ChangeMedicines(int ID, string Categories, string Names, string Description, string Price, string Amount, string Presence)//Передача значений с предыдущей формы (Medicines) для отображения 
        {
            InitializeComponent();
            MedId = ID;
            txtCategories.Text = Categories;
            txtName.Text = Names;
            txtDiscription.Text = Description;
            txtPrice.Text = Price.Remove(Price.Length - 5, 5);
            txtAmount.Text = Amount;
            if (Presence == "True")
            {
                checkPresence.Checked = true;
            }
        }

        private void btnCateg_Click(object sender, EventArgs e) //Открытие модульной формы при нажатии на кнопку выбрать для выбора нужной категории
        {
            ChooseCategories choisecat = new ChooseCategories(txtCategories);
            choisecat.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e) //Изменение данных при нажатии на кнопку изменить
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                if (txtAmount.TextLength != 0 && txtCategories.TextLength != 0 && txtDiscription.TextLength != 0 && txtName.TextLength != 0 && txtPrice.TextLength != 0)
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        SqlCommand cmd_1 = conn.CreateCommand();
                        SqlCommand cmd_2 = conn.CreateCommand();
                        cmd_1.CommandText = "SELECT IDCategory FROM [Categories] WHERE Name = @name";
                        cmd_1.Parameters.AddWithValue(@"name", txtCategories.Text);
                        int typeEx = int.Parse(cmd_1.ExecuteScalar().ToString());
                        cmd.CommandText = "UPDATE [Medicines] SET  Name = @Name, IDCategory = @IDCategory, Description = @Description, Price = @Price, Amount = @Amount, Presence = @Presence WHERE IDMedicine   = @IDMedicine";
                        cmd.Parameters.AddWithValue(@"IDMedicine", MedId);
                        cmd.Parameters.AddWithValue(@"IDCategory", typeEx);
                        cmd.Parameters.AddWithValue(@"Name", txtName.Text);
                        cmd.Parameters.AddWithValue(@"Description", txtDiscription.Text);
                        cmd.Parameters.AddWithValue(@"Price", txtPrice.Text);
                        cmd.Parameters.AddWithValue(@"Amount", txtAmount.Text);
                        string how;
                        if (checkPresence.Checked == true)
                        {
                            how = "True";
                        }
                        else
                        {
                            how = "False";
                        }
                        cmd.Parameters.AddWithValue(@"Presence", how);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно изменена!");
                        Medicines medicines = new Medicines();
                        medicines.Show();
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
                else
                {
                    MessageBox.Show("Введите данные!");
                }
            }


        }

        private void picClose_Click(object sender, EventArgs e)  //Закрытие данной формы и переход на предыдущую (Medicines) 
        {
            this.Close();
            GC.Collect();
            Medicines medicines = new Medicines();
            medicines.Visible = true;
            medicines.ShowInTaskbar = true;
        }

        //Разрешение вводить в поле только цифры
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
