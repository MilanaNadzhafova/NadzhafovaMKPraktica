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
    public partial class Basket : Form
    {
        int ID, IndexRow, AllPrice;
        public Basket()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e) // Переход к каталогу при нажатии на крестик
        {
            this.Hide();
            Catalog catalog = new Catalog();
            catalog.Show();
        }
        private void Basket_Load(object sender, EventArgs e) // Отображение состава корзины при прогрузке формы
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                string query = "SELECT bc.IDConsist, m.Name, bc.Amount, bc.Price " +
 "FROM BasketConsist as bc  INNER JOIN Medicines as m ON bc.IDMedicines = m.IDMedicine WHERE bc.IDBasket = @ID";

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"ID", Autorization.userID.IDBasket);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    tableConsist.DataSource = dt;
                    tableConsist.Update();
                    
                    tableConsist.Columns[1].HeaderText = "Лекарства";
                    tableConsist.Columns[2].HeaderText = "Количество";
                    tableConsist.Columns[3].HeaderText = "Цена";

                    tableConsist.Columns[0].Visible = false;

                    tableConsist.Refresh();
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
            UpdatePrice();
        }
        private void UpdatePrice() //Вывод общей суммы товаров, находящихся в корзине
        {
            for(int i =0;i<tableConsist.Rows.Count;i++)
            {
                AllPrice += Convert.ToInt32(tableConsist[3,i].Value);
            }
            txtPrice.Text = AllPrice.ToString() + " руб.";
            AllPrice = 0;
        }
        private void btnDelete_Click(object sender, EventArgs e) // Удаление определенного товара из корзины
        {
            string message = $"Вы действительно хотите удалить данный товар из корзины?";
            string caption = "Удаление";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (tableConsist.SelectedRows.Count == 1)
            {
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [BasketConsist] WHERE IDCOnsist = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            tableConsist.Refresh();
                            MessageBox.Show("Запись удалена!");
                            //Отображение состава корзины после удаления записи
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT bc.IDConsist, m.Name, bc.Amount, bc.Price " +
 "FROM BasketConsist as bc  INNER JOIN Medicines as m ON bc.IDMedicines = m.IDMedicine WHERE bc.IDBasket = @ID", conn);
                            dataAdapter.SelectCommand.Parameters.AddWithValue(@"ID", Autorization.userID.IDBasket);
                               DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                           
                            tableConsist.DataSource = dataTable;

                            tableConsist.Columns[1].HeaderText = "Лекарства";
                            tableConsist.Columns[2].HeaderText = "Количество";
                            tableConsist.Columns[3].HeaderText = "Цена";

                            tableConsist.Columns[0].Visible = false;
                            tableConsist.Refresh();
                            tableConsist.ClearSelection();
                            UpdatePrice();
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
                if (tableConsist.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }
        private void btnAddOnBasket_Click(object sender, EventArgs e) // Переход на следующую форму для оформления заказа
        {
            if(tableConsist.Rows.Count != 0)
            {
                string price = txtPrice.Text;
                this.Hide();
                OrderUser orderUser = new OrderUser(price);
                orderUser.Show();
            }
            else
            {
                MessageBox.Show("Но вы не добавили ни одного товара!(((");
            }
        }
        private void tableConsist_CellClick(object sender, DataGridViewCellEventArgs e) // Извлечение ID записи по нажатию на строку
        {
            try
            {
                tableConsist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(tableConsist[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }
    }
}
