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
    public partial class AddMedicines : Form
    {
        public AddMedicines()
        {
            InitializeComponent();
        }

        //Создание глобальной переменной для дальнейшей работы с ней
        static public Global type;
        public struct Global
        {
            public int type;
        }

        private void picClose_Click(object sender, EventArgs e) //Закрытие данной формы и переход на предыдущую (Medicines) 
        {
            this.Close();
            GC.Collect();
            Medicines medicines = new Medicines();
            medicines.Visible = true;
            medicines.ShowInTaskbar = true;
        }

        //При нажатии на текстовое поле оно очищается
        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }
        private void txtCategories_Click(object sender, EventArgs e)
        {
            txtCategories.Clear();
        }
        private void txtAmount_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
        }
        private void txtDiscription_Click(object sender, EventArgs e)
        {
            txtDiscription.Clear();
        }
        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e) //Добавление записи в БД при нажатии на копку добавить по заполнению необходимых полей
        {
            if (txtAmount.TextLength != 0 && txtCategories.TextLength !=0 && txtDiscription.TextLength!=0 && txtName.TextLength !=0 && txtPrice.TextLength != 0)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO [Medicines] VALUES (@IDCategory,@Name,@Description,@Price,@Amount,@Presence)";
                        cmd.Parameters.AddWithValue(@"IDCategory", type.type);
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
                        MessageBox.Show("Запись успешно добавлена!");
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
            }

            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void btnCateg_Click(object sender, EventArgs e) //Открытие модульной формы при нажатии на кнопку выбрать для выбора нужной категории
        {
            ChooseCategories choisecat = new ChooseCategories(txtCategories);
            choisecat.ShowDialog();
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
