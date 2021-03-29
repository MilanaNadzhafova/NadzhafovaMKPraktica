using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadzhafovaMKPraktica
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        //Очистка текстбоксов при нажатии на них
        private void Registration_Load(object sender, EventArgs e)
        {

        }
        private void txtSurname_Click(object sender, EventArgs e)
        {
            txtSurname.Clear();
        }
        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }
        private void txtPatronymic_Click(object sender, EventArgs e)
        {
            txtPatronymic.Clear();
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
        private void txtPassword1_Click(object sender, EventArgs e)
        {
            txtPassword1.Clear();
        }
        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
        }
        private void txtEmail_Click_1(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }


        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Autorization autorization = new Autorization();
            autorization.Visible = true;
            autorization.ShowInTaskbar = true;
        }//Переход к форме авторизации при нажатии на крестик

        private void btnRegistration_Click(object sender, EventArgs e) //Добавление записи о пользователи при нажатии на кнопку зарегистрироваться
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into [Users] values(@Email,@Password,@Surname,@Name,@Patronymic,@Birthday,@NumberPhone,@Roled)";
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Patronymic", txtPatronymic.Text);
                    cmd.Parameters.AddWithValue("@Birthday", dateOfBirth.Value);
                    cmd.Parameters.AddWithValue("@NumberPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Roled", "U");
                    cmd.ExecuteNonQuery();

                    string query = "Select IDUser From Users Where Email = @Email";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.Parameters.AddWithValue("@Email", txtEmail.Text);
                    int ID = Convert.ToInt32(cmd2.ExecuteScalar());
                    string query2 = "insert into Baskets values(@IDUser)";
                    SqlCommand cmd3 = new SqlCommand(query2, con);
                    cmd3.Parameters.AddWithValue("@IDUser", ID);
                    cmd3.ExecuteScalar();

                    Autorization menu = new Autorization();
                    menu.Show();
                    this.Close();
                    MessageBox.Show("Вы успешно зарегистрированы, войдите!");
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

        private void txtEmail_Validated(object sender, EventArgs e) //Проверка корректности ввода Email
        {
            if (Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
            }
            else
            {
                MessageBox.Show("Неверно введен Email.\n Формат x@x.x");
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e) //Проверка пароля на соответствования требованиям
        {
            if (!Regex.IsMatch(txtPassword.Text, @"(?=^.{6,}$)((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$)"))
            {
                MessageBox.Show("Неверно введен пароль!!!\n Пароль должен содержать более 6 символов, минимум 1 строчную, минимум 1 прописную, минимум 1 цифру");
            }
        }

        private void txtPassword1_Validated(object sender, EventArgs e) //Проверка полей пароль и повторите пароль на эквивалентность
        {
            if (txtPassword.Text != txtPassword1.Text)
            {
                MessageBox.Show("Пароли не совпадают!!!");
                txtPassword1.Clear();
                txtPassword.Focus();
            }
        }

        //Отображение пароля звездочками
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            txtPassword1.PasswordChar = '*';
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
