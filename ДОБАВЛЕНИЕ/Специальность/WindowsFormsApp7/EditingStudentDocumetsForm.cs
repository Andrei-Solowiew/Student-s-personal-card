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
    public partial class EditingStudentDocumetsForm : Form
    {
        public EditingStudentDocumetsForm()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Документы_студента". При необходимости она может быть перемещена или удалена.
            this.документы_студентаTableAdapter1.Fill(this.бД3DataSet.Документы_студента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Документы_студента". При необходимости она может быть перемещена или удалена.
            this.документы_студентаTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Документы_студента);

        }

        private void EditingStudentDocumetsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
