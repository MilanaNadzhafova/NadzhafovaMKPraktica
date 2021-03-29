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
    public partial class Medicines : Form
    {
        int ID, IndexRow;
        string Categories, Names, Description, Price, Amount, Presence;

        private void btnChange_Click(object sender, EventArgs e) //При нажатии на кнопку изменить происходит на соответствующую форму с передачей необходимой информации
        {
            if (tableMedicines.SelectedRows.Count == 1)
            {
                Categories = tableMedicines[2, IndexRow].Value.ToString();
                Names = tableMedicines[3, IndexRow].Value.ToString();
                Description = tableMedicines[4, IndexRow].Value.ToString();
                Price = tableMedicines[5, IndexRow].Value.ToString();
                Amount = tableMedicines[6, IndexRow].Value.ToString();
                Presence = tableMedicines[7, IndexRow].Value.ToString();
                this.Visible = false;
                this.ShowInTaskbar = false;
                ChangeMedicines changeMedicines = new ChangeMedicines(ID, Categories, Names, Description, Price, Amount, Presence);
                changeMedicines.ShowDialog();
            }
            else
            {
                if (tableMedicines.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для изменения!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для изменения!");
                }
            }
        }

        private void tableMedicines_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // При двойном нажатии на строку в таблице происходит переход на форму информации о товаре с переачей необходимых значений
        {
            Categories = tableMedicines[2, IndexRow].Value.ToString();
            Names = tableMedicines[3, IndexRow].Value.ToString();
            Description = tableMedicines[4, IndexRow].Value.ToString();
            Price = tableMedicines[5, IndexRow].Value.ToString();
            Amount = tableMedicines[6, IndexRow].Value.ToString();
            Presence = tableMedicines[7, IndexRow].Value.ToString();
            this.Visible = false;
            this.ShowInTaskbar = false;
            ShowMedicines show = new ShowMedicines(Categories, Names, Description, Price, Amount, Presence);
            show.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e) //При нажатии на кнопку добавить происходит переход на соответствующую форму
        {
            this.Close();
            GC.Collect();
            AddMedicines medicines = new AddMedicines();
            medicines.Visible = true;
            medicines.ShowInTaskbar = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) //Удаление товара при нажатии на соответствующую кнопку
        {
            string message = $"Вы действительно хотите удалить {ID} запись?";
            string caption = "Удаление";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (tableMedicines.SelectedRows.Count == 1)
            {
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [Medicines] WHERE IDMedicine = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            tableMedicines.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT le.IDMedicine,le.IDCategory,pw.Name,le.Name,le.Description,le.Price," +
                    "le.Amount, le.Presence FROM Medicines AS le INNER JOIN Categories as pw ON pw.IDCategory = le.IDCategory", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            tableMedicines.DataSource = dataTable;
                            tableMedicines.Columns[2].Width = 70;
                            tableMedicines.Columns[3].Width = 70;
                            tableMedicines.Columns[5].Width = 70;
                            tableMedicines.Columns[6].Width = 70;
                            tableMedicines.Columns[7].Width = 70;

                            tableMedicines.Columns[2].HeaderText = "Категория";
                            tableMedicines.Columns[3].HeaderText = "Название";
                            tableMedicines.Columns[5].HeaderText = "Цена";
                            tableMedicines.Columns[6].HeaderText = "Количество";
                            tableMedicines.Columns[7].HeaderText = "Наличие";
                            tableMedicines.Columns[1].Visible = false;
                            tableMedicines.Columns[0].Visible = false;
                            tableMedicines.Columns[4].Visible = false;
                            tableMedicines.Refresh();
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
                if (tableMedicines.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }
        private void tableMedicines_CellClick(object sender, DataGridViewCellEventArgs e) //При нажатии на строку присваивается ID товара
        {
            try
            {
                tableMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(tableMedicines[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }

        public Medicines()
        {
            InitializeComponent();
        }

        private void Medicines_Load(object sender, EventArgs e) //Отображение всех товаров при прогрузке формы
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                string query = "SELECT le.IDMedicine,le.IDCategory,pw.Name,le.Name,le.Description,le.Price," +
                    "le.Amount, le.Presence FROM Medicines AS le INNER JOIN Categories as pw ON pw.IDCategory = le.IDCategory ";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    tableMedicines.DataSource = dt;
                    tableMedicines.Update();

                    tableMedicines.Columns[2].Width = 70;
                    tableMedicines.Columns[3].Width = 70;
                    tableMedicines.Columns[5].Width = 70;
                    tableMedicines.Columns[6].Width = 70;
                    tableMedicines.Columns[7].Width = 70;

                    tableMedicines.Columns[2].HeaderText = "Категория";
                    tableMedicines.Columns[3].HeaderText = "Название";
                    tableMedicines.Columns[5].HeaderText = "Цена";
                    tableMedicines.Columns[6].HeaderText = "Количество";
                    tableMedicines.Columns[7].HeaderText = "Наличие";
                    tableMedicines.Columns[1].Visible = false;
                    tableMedicines.Columns[0].Visible = false;
                    tableMedicines.Columns[4].Visible = false;
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

        private void picClose_Click(object sender, EventArgs e) //Закрытие формы и переход к меню администратора
        {
            this.Close();
            GC.Collect();
            MenuAdmin menu = new MenuAdmin();
            menu.Visible = true;
            menu.ShowInTaskbar = true;

        }

        private void btnSearch_Click(object sender, EventArgs e) //Поиск по товарам
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                string query = "SELECT le.IDMedicine,le.IDCategory,pw.Name,le.Name,le.Description,le.Price,le.Amount, le.Presence FROM Medicines AS le INNER JOIN Categories as pw ON pw.IDCategory = le.IDCategory " +
                    "WHERE le.Name like '%" + txtSearch.Text + "%' or le.Price like '%" + txtSearch.Text + "%' or le.Amount like '%" + txtSearch.Text + "%' or pw.Name like '%" + txtSearch.Text + "%'";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    tableMedicines.DataSource = dt;
                    tableMedicines.Update();
                    tableMedicines.Columns[2].Width = 70;
                    tableMedicines.Columns[3].Width = 70;
                    tableMedicines.Columns[5].Width = 70;
                    tableMedicines.Columns[6].Width = 70;
                    tableMedicines.Columns[7].Width = 70;

                    tableMedicines.Columns[2].HeaderText = "Категория";
                    tableMedicines.Columns[3].HeaderText = "Название";
                    tableMedicines.Columns[5].HeaderText = "Цена";
                    tableMedicines.Columns[6].HeaderText = "Количество";
                    tableMedicines.Columns[7].HeaderText = "Наличие";
                    tableMedicines.Columns[1].Visible = false;
                    tableMedicines.Columns[0].Visible = false;
                    tableMedicines.Columns[4].Visible = false;
                    tableMedicines.Refresh();
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
}
