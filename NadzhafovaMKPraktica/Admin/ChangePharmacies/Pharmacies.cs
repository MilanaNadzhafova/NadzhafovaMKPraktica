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
    public partial class Pharmacies : Form
    {
        int ID;
        string Names, Addres, TimeWork;
        int IndexRow;
        public Pharmacies()
        {
            InitializeComponent();
        }

        private void Pharmacies_Load(object sender, EventArgs e) //Загрузка информации об аптеках при прогрузки формы
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmPanaceyaDataSet.Pharmacies". При необходимости она может быть перемещена или удалена.
            this.pharmaciesTableAdapter.Fill(this.pharmPanaceyaDataSet.Pharmacies);
        }

        private void btnSearch_Click(object sender, EventArgs e) //Поиск по аптекам
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Pharmacies  WHERE Name like '%" + txtSearch.Text + "%'or Address like'%" + txtSearch.Text + "%' or TimeWork like'%" + txtSearch.Text + "%'", conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    tableOrders.DataSource = dataTable;
                    tableOrders.Refresh();
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

        private void tableOrders_CellClick(object sender, DataGridViewCellEventArgs e) //При нажатии на строку присваеивается ID аптеки
        {
            try
            {
                tableOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(tableOrders[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e) //Удаление определенной точки выдачи при нажатии на кнопку удалить
        {
            string message = $"Вы действительно хотите удалить {ID} запись?";
            string caption = "Удаление";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (tableOrders.SelectedRows.Count == 1)
            {
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [Pharmacies] WHERE IDPharm = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            tableOrders.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Pharmacies ", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            tableOrders.DataSource = dataTable;
                            tableOrders.Refresh();
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
                if (tableOrders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e) //При нажатии на кнопку изменить происходит на соответствующую форму с передачей необходимой информации
        {
            if (tableOrders.SelectedRows.Count == 1)
            {
                Names = tableOrders[1, IndexRow].Value.ToString();
                Addres = tableOrders[2, IndexRow].Value.ToString();
                TimeWork = tableOrders[3, IndexRow].Value.ToString();
                this.Visible = false; ;
                this.ShowInTaskbar = false;
                ChangePharmacies changePost = new ChangePharmacies(ID, Names, Addres, TimeWork);
                changePost.ShowDialog();

            }
            else
            {
                if (tableOrders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для изменения!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для изменения!");
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

        private void btnAdd_Click(object sender, EventArgs e) //При нажатии на кнопку добавить открытие соответствующей формы
        {
            this.Close();
            GC.Collect();
            AddPharmacies pharm = new AddPharmacies();
            pharm.Visible = true;
            pharm.ShowInTaskbar = true;
        }
    }
}
