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
    public partial class Orders : Form
    {
        int ID, IndexRow;
        string Status, Pay, Pharm, IDStatus, Email, Adress;

        private void btnChange_Click(object sender, EventArgs e) //Передача необходимых данных (выбранной строки) на следующую форму (ChangeOrders)
        {
            if (tableOrders.SelectedRows.Count == 1)
            {
                Status = tableOrders[2, IndexRow].Value.ToString();
                Pay = tableOrders[4, IndexRow].Value.ToString();
                Pharm = tableOrders[6, IndexRow].Value.ToString();
                IDStatus = tableOrders[3, IndexRow].Value.ToString();
                Email = tableOrders[9, IndexRow].Value.ToString();
                Adress = tableOrders[10, IndexRow].Value.ToString();
                this.Visible = false;
                this.ShowInTaskbar = false;
                ChangeOrders changeOrders = new ChangeOrders(ID, Pay, Status, IDStatus, Pharm, Email,Adress);
                changeOrders.ShowDialog();
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

        private void btnSearch_Click(object sender, EventArgs e) //Поиск по всем атрибутам 
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                string query = "SELECT z.IDOrder,s.Status,z.IDStatus,l.Method, z.IDPay,k.Name,z.IDPharm, z.IDBasket FROM Orders AS z INNER JOIN Status AS s ON z.IDStatus = s.IDStatus INNER JOIN Pharmacies AS k ON z.IDPharm =  k.IDPharm INNER JOIN PayMethod AS l ON z.IDPay = l.IDPay  " +
                    " WHERE s.Status like '%" + txtSearch.Text + "%' or l.Method like '%" + txtSearch.Text + "%' or k.Name like '%" + txtSearch.Text + "%' ";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    tableOrders.DataSource = dt;
                    tableOrders.Update();

                    tableOrders.Columns[2].HeaderText = "Статус";
                    tableOrders.Columns[4].HeaderText = "Оплата";
                    tableOrders.Columns[6].HeaderText = "Пункт выдачи";

                    tableOrders.Columns[5].Visible = false;
                    tableOrders.Columns[1].Visible = false;
                    tableOrders.Columns[3].Visible = false;
                    tableOrders.Columns[7].Visible = false;
                    tableOrders.Columns[8].Visible = false;
                    tableOrders.Columns[0].Visible = false;
                    tableOrders.Columns[9].Visible = false;
                    tableOrders.Columns[10].Visible = false;
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

        private void Orders_Load(object sender, EventArgs e) //Отображении информации о заказах в таблице при прогрузке формы
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3331SL\SQLEXPRESS;Initial Catalog=PharmPanaceya;Integrated Security=True"))
            {
                string query = "SELECT z.IDOrder,s.Status,z.IDStatus,l.Method, z.IDPay,k.Name,z.IDPharm, z.IDBasket, us.Email, k.Address FROM Orders AS z " +
                    "INNER JOIN Status AS s ON z.IDStatus = s.IDStatus INNER JOIN Pharmacies AS k ON z.IDPharm =  k.IDPharm INNER JOIN PayMethod AS l ON z.IDPay = l.IDPay " +
                    "INNER JOIN Baskets AS b ON z.IDBasket = b.IDBasket INNER JOIN Users AS us ON b.IDUser = us.IDUser";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    tableOrders.DataSource = dt;
                    tableOrders.Update();
                
                    tableOrders.Columns[2].Width = 120;
                    tableOrders.Columns[4].Width = 130;
                    tableOrders.Columns[6].Width = 100;
      
                    tableOrders.Columns[2].HeaderText = "Статус";
                    tableOrders.Columns[4].HeaderText = "Оплата";
                    tableOrders.Columns[6].HeaderText = "Пункт выдачи";
                  

                    tableOrders.Columns[5].Visible = false;
                    tableOrders.Columns[1].Visible = false;
                    tableOrders.Columns[3].Visible = false;
                    tableOrders.Columns[7].Visible = false;
                    tableOrders.Columns[8].Visible = false;
                    tableOrders.Columns[0].Visible = false;
                    tableOrders.Columns[9].Visible = false;
                    tableOrders.Columns[10].Visible = false;



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

        private void tableOrders_CellClick(object sender, DataGridViewCellEventArgs e) //При нажатии на строку вытаскивается ID заказа
        {
            try
            {
                tableOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(tableOrders[1, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }

        private void picClose_Click(object sender, EventArgs e) // При нажитии на крестик происходит закрытие формы и переход на предыдущую (Меню)
        {
            this.Close();
            GC.Collect();
            MenuAdmin menu = new MenuAdmin();
            menu.Visible = true;
            menu.ShowInTaskbar = true;
        }

        public Orders()
        {
            InitializeComponent();
        }
    }
}
