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
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e) // Закрытие формы и переход на домашнюю, по нажатию на крестик
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void picBtnDiabetes_Click(object sender, EventArgs e) // Переход на первую категорию
        {
            this.Hide();
            Diabetes diabetes = new Diabetes();
            diabetes.Show();
        }

        private void picBtnVision_Click(object sender, EventArgs e) // Переход на вторую категорию
        {
            this.Hide();
            Vision vision = new Vision();
            vision.Show();
        }

        private void picBtnJoints_Click(object sender, EventArgs e) // Переход на третью категорию
        {
            this.Hide();
            Joints joints = new Joints();
            joints.Show();
        }

        private void picBtnHygiene_Click(object sender, EventArgs e) // Переход на четвертую категорию
        {
            this.Hide();
            Hygiene hygiene = new Hygiene();
            hygiene.Show();
        }

        private void picBtnBasket_Click_1(object sender, EventArgs e) // Переход к корзине
        {
            this.Hide();
            Basket basket = new Basket();
            basket.Show();
        }

    }
}
