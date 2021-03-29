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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void picBtnCatalog_Click(object sender, EventArgs e) // Переход к каталогу 
        {
            this.Hide();
            Catalog catalog = new Catalog();
            catalog.Show();
        }

        private void picClose_Click(object sender, EventArgs e) //Переход к авторизации, по нажатию на крестик
        {
            this.Hide();
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        private void picBasket_Click_1(object sender, EventArgs e) // Переход к корзине
        {
            Basket basket = new Basket();
            basket.Show();
            this.Hide();
        }

    }
}
