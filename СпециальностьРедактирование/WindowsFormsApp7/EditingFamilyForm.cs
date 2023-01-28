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
    public partial class EditingFamilyForm : Form
    {
        public EditingFamilyForm()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Семья". При необходимости она может быть перемещена или удалена.
            this.семьяTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Семья);

        }
    }
}
