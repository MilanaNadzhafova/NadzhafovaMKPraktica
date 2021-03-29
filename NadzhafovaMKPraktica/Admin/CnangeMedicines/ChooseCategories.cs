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
    public partial class ChooseCategories : Form
    {
        TextBox txt;
        public ChooseCategories(TextBox categ) //Передача значения с предыдущей формы (Medicines) 
        {
            InitializeComponent();
            txt = categ;
        }

        private void ChooseCategories_Load(object sender, EventArgs e) // Отображение категорий при загрузке формы
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmPanaceyaDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.pharmPanaceyaDataSet.Categories);
        }

        private void btnAdd_Click(object sender, EventArgs e) //Передача выбранного значения в необходимое текстовое поле
        {
            txt.Text = list.GetItemText(list.SelectedItem);
            AddMedicines.type.type = int.Parse(list.GetItemText(list.SelectedValue));
            this.Close();
            GC.Collect();
        }
    }
}
