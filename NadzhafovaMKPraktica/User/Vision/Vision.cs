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
    public partial class Vision : Form
    {
        public Vision()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e) // Переход на форму каталога
        {
            this.Close();
            GC.Collect();
            Catalog catalog = new Catalog();
            catalog.Visible = true;
            catalog.ShowInTaskbar = true;
        }

        private void Vision_Load(object sender, EventArgs e)
        {

        }

        // Переходы на форму информации о продуктах с передачей фотографии
        private void picBtnProd3_Click(object sender, EventArgs e)
        {
            System.Drawing.Image img = picBtnProd3.Image;
            ToGierIMG(img, 1032);
        }
        private void picBtnProd2_Click(object sender, EventArgs e)
        {

            System.Drawing.Image img = picBtnProd2.Image;
            ToGierIMG(img, 14);
        }
        private void picBtnProd1_Click(object sender, EventArgs e)
        {
            System.Drawing.Image img = picBtnProd1.Image;
            ToGierIMG(img, 8);
        }
        private void picBtnProd4_Click(object sender, EventArgs e)
        {
            System.Drawing.Image img = picBtnProd4.Image;
            ToGierIMG(img, 1033);
        }

        private void ToGierIMG(Image img, int a)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            InfoForProduct info = new InfoForProduct(img, a);
            info.ShowDialog();
        }// Метод для передачи информации о товарах
    }
}
