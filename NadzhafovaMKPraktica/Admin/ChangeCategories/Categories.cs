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
    public partial class Categories : Form
    {
        int ID;
        int IndexRow;

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e) //Прогрузка наименований категорий из базы данных при загрузки формы
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmPanaceyaDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.pharmPanaceyaDataSet.Categories);
        }

        private void picClose_Click(object sender, EventArgs e) // Закрытие формы и переход назад, в меню 
        {
            this.Close();
            GC.Collect();
            MenuAdmin menu = new MenuAdmin();
            menu.Visible = true;
            menu.ShowInTaskbar = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) // Поиск по категориям
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Categories WHERE Name like '%" + txtSearch.Text + "%'", conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    tableCategories.DataSource = dataTable;
                    tableCategories.Refresh();
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

        private void tableCategories_CellClick(object sender, DataGridViewCellEventArgs e) //При выделении строки берется ID категории
        {
            try
            {
                tableCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(tableCategories[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
                txtAdd.Text = tableCategories[1, IndexRow].Value.ToString();
            }
            catch { }
        }

        private void btnChange_Click(object sender, EventArgs e) //Изменение наименования категории при нажатии на кнопку изменить (предваритиельно изменив название в соответсвующем текстбоксе)
        {
            if (txtAdd.Text != string.Empty)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                {

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE [Categories] SET Name = @Name WHERE IDCategory = @ID";
                        cmd.Parameters.AddWithValue(@"ID", ID);
                        cmd.Parameters.AddWithValue(@"Name", txtAdd.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Categories ", conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        tableCategories.DataSource = dataTable;
                        tableCategories.Refresh();
                        txtAdd.Clear();
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
        }

        private void btnDelete_Click(object sender, EventArgs e) //Удаление определенной категории при нажатии на кнопку удалить
        {
            string message = $"Вы действительно хотите удалить {ID} запись?";
            string caption = "Удаление";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (tableCategories.SelectedRows.Count == 1)
            {
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [Categories] WHERE IDCategory = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            tableCategories.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Categories ", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            tableCategories.DataSource = dataTable;
                            tableCategories.Refresh();
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
                    MessageBox.Show("Запись не удалена!");
                }
            }
            else
            {
                if (tableCategories.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)  //Добавление наименования категории при нажатии на кнопку изменить (предваритиельно изменив название в соответсвующем текстбоксе)
        {
          

            if (txtAdd.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();

                        cmd.CommandText = "INSERT INTO [Categories] VALUES (@Name)";
                        cmd.Parameters.AddWithValue(@"Name", txtAdd.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Категория успешно добавлена!");
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Categories ", conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        tableCategories.DataSource = dataTable;
                        tableCategories.Refresh();
                        txtAdd.Clear();
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
        }

        private void txtAdd_Click(object sender, EventArgs e) 
        {
           
        }
    }
}
