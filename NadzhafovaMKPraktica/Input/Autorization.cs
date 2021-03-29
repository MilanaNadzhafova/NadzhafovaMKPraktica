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

    public partial class Autorization : Form
    {
        //Глобальные переменные для использования их значений в других формах
        static public Global userID;
        public struct Global
        {
            public int ID;
            public int IDBasket;
            public string Email;
        }

        public Autorization()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e) //Закрытие приложения при нажатии на крестик
        {
            Application.Exit();
        }

        private void btnEntrance_Click(object sender, EventArgs e) //Вход 
        {
            if (txtLogin.Text != "" && txtPassword.Text != "")
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                {
                   //Присвоение необходимых значений, которые в дальнейшем будут использоваться в глобальных переменных
                    string sql_1 = "SELECT IDUser FROM [Users] WHERE Email = @Email";
                    string sql_2 = "SELECT IDBasket FROM [Baskets] WHERE IDUser = @IDUser";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "select Password from [Users] where Email = @Email";
                        cmd.Parameters.AddWithValue("@Email", txtLogin.Text);
                        string password = Convert.ToString(cmd.ExecuteScalar());

                        //Сравнение введенных значений со значениями, находящимися в БД
                        if (password != "")
                        {
                            if (txtPassword.Text == password)
                            {
                                cmd.CommandText = "select Roled from [Users] where Email = @Email_1";
                                cmd.Parameters.AddWithValue("@Email_1", txtLogin.Text);
                                string roleid = Convert.ToString(cmd.ExecuteScalar());
                                switch (roleid)
                                {
                                    //Переходы на форму в зависимости от роли пользователя
                                    case "A":
                                        {
                                            MenuAdmin menuAdmin = new MenuAdmin();
                                            menuAdmin.Show();
                                            this.Hide();
                                        }
                                        break;
                                    case "U":
                                        {
                                            SqlCommand cmd_1 = new SqlCommand(sql_1, con);
                                            cmd_1.Parameters.AddWithValue("@Email", txtLogin.Text);
                                            userID.ID = Convert.ToInt32(cmd_1.ExecuteScalar());
                                           
                                            SqlCommand cmd_2 = new SqlCommand(sql_2, con);
                                            cmd_2.Parameters.AddWithValue("@IDUser", userID.ID.ToString());
                                            userID.IDBasket = Convert.ToInt32(cmd_2.ExecuteScalar());

                                            userID.Email = txtLogin.Text;
                                            Home user = new Home();
                                            user.Show();
                                            this.Hide();
                                        }
                                        break;
                                }
                            }
                            else { MessageBox.Show("Неверный пароль!"); }
                        }
                        else { MessageBox.Show("Неверный Email!"); }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex));
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        } //Отображение пароля звездочками

        private void lbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        } //Переход на форму регистрации


        //Очистка текстбоксов при нажатии на них
        private void txtLogin_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        //Закрытие приложения при нажатии на крестик
        private void picClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
