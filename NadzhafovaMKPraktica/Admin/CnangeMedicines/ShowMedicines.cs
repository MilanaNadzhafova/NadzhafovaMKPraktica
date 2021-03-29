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
    public partial class ShowMedicines : Form
    {
        //Передача значений с предыдущей формы (Medicines) для дальнейшего отображения
        public ShowMedicines(string Categories, string Name, string Description, string Price, string Amount, string Presence)
        {
            InitializeComponent();
            txtCategory.Text = Categories;
            txtName.Text = Name;
            txtDescription.Text = Description;
            txtPrice.Text = Price.Remove(Price.Length - 5, 5);
            txtAmount.Text = Amount;
            if (Presence == "True")
            {
                checkPresence.Checked = true;
            }
        }

        private void picClose_Click(object sender, EventArgs e) //Закрытие формы и переход к меню администратора
        {
            this.Close();
            GC.Collect();
            Medicines medicines = new Medicines();
            medicines.Visible = true;
            medicines.ShowInTaskbar = true;
        }
    }
}
