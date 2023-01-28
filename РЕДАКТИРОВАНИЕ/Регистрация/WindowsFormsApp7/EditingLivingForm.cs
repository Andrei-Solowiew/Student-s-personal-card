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
    public partial class EditingLivingForm : Form
    {
        public EditingLivingForm()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Место_проживания_студента". При необходимости она может быть перемещена или удалена.
            this.место_проживания_студентаTableAdapter1.Fill(this.бД3DataSet.Место_проживания_студента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Место_проживания_студента". При необходимости она может быть перемещена или удалена.
            this.место_проживания_студентаTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Место_проживания_студента);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
