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
    public partial class AddPharmacies : Form
    {
        public AddPharmacies()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) // Добавление записи об аптеке в БД после заполнения необходимых текстовых полей
        {
            if (txtName.Text != string.Empty && txtAddres.Text != string.Empty && txtTimeWork.Text != string.Empty)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();

                        cmd.CommandText = "INSERT INTO [Pharmacies] VALUES (@Name,@Address, @TimeWork)";
                        cmd.Parameters.AddWithValue(@"Name", txtName.Text);
                        cmd.Parameters.AddWithValue(@"Address", txtAddres.Text);
                        cmd.Parameters.AddWithValue(@"TimeWork", txtTimeWork.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Аптека успешно добавлена!");
                        Pharmacies pharmacies = new Pharmacies();
                        pharmacies.Show();
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

        private void picClose_Click(object sender, EventArgs e) // Закрытие формы при нажатии на крестик и переход на предыдущую (Аптеки)
        {
            this.Close();
            GC.Collect();
            Pharmacies pharm = new Pharmacies();
            pharm.Visible = true;
            pharm.ShowInTaskbar = true;
        }
         
        //При нажатии на текстовое поле оно очищается
        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }
        private void txtAddres_Click(object sender, EventArgs e)
        {
            txtAddres.Clear();
        }
        private void txtTimeWork_Click(object sender, EventArgs e)
        {
            txtTimeWork.Clear();
        }

        private void txtTimeWork_KeyPress(object sender, KeyPressEventArgs e) //Разрешение вводить в поле только цифры
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 58 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
