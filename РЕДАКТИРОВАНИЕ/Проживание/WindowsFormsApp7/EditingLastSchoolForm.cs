using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class EditingLastSchoolForm : Form
    {
        public EditingLastSchoolForm()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Данные_о_прошлом_УЗ". При необходимости она может быть перемещена или удалена.
            this.данные_о_прошлом_УЗTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Данные_о_прошлом_УЗ);

        }
    }
}
