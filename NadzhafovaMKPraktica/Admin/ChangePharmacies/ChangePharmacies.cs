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
    public partial class ChangePharmacies : Form
    {
        int PharmID;
        public ChangePharmacies(int ID, string Names, string Addres, string TimeWork) //Передача с предыдущей формы (аптеки) информации
        {
            InitializeComponent();
            txtName.Text = Names;
            txtAddres.Text = Addres;
            txtTimeWork.Text = TimeWork;
            PharmID = ID;
        }

        private void picClose_Click(object sender, EventArgs e) //При нажатии на крестик происходит закрытие данной формы и открытие предыдущей (Аптеки)
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

        private void btnChange_Click(object sender, EventArgs e) //Изменение информации об аптеках при нажатии на кнопку изменить
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                if (txtName.TextLength != 0 && txtAddres.TextLength != 0 && txtTimeWork.TextLength != 0)
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE [Pharmacies] SET Name = @Name,Address = @Addres, TimeWork = @TimeWork WHERE IDPharm = @IDPharm";
                        cmd.Parameters.AddWithValue(@"IDPharm", PharmID);
                        cmd.Parameters.AddWithValue(@"Name", txtName.Text);
                        cmd.Parameters.AddWithValue(@"Addres", txtAddres.Text);
                        cmd.Parameters.AddWithValue(@"TimeWork", txtTimeWork.Text);
                        cmd.ExecuteNonQuery();
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
                else
                {
                    MessageBox.Show("Введите данные!");
                }
            }
        }
    }
}
