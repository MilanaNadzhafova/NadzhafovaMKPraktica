using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadzhafovaMKPraktica
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        //Переходы к соответствующим формам
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Autorization autorization = new Autorization();
            autorization.Visible = true;
            autorization.ShowInTaskbar = true;
        }
        private void changeCategories_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Categories categories = new Categories();
            categories.Visible = true;
            categories.ShowInTaskbar = true;
        }
        private void changeMedicines_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Medicines medicines = new Medicines();
            medicines.Visible = true;
            medicines.ShowInTaskbar = true;
        }
        private void changeOrders_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Orders orders = new Orders();
            orders.Visible = true;
            orders.ShowInTaskbar = true;
        }
        private void changePharm_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Pharmacies pharm = new Pharmacies();
            pharm.Visible = true;
            pharm.ShowInTaskbar = true;
        }
    }
}
