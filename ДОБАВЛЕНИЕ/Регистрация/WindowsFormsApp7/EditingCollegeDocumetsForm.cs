﻿using System;
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
    public partial class EditingCollegeDocumetsForm : Form
    {
        public EditingCollegeDocumetsForm()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Документы_от_колледжа". При необходимости она может быть перемещена или удалена.
            this.документы_от_колледжаTableAdapter1.Fill(this.бД3DataSet.Документы_от_колледжа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Документы_от_колледжа". При необходимости она может быть перемещена или удалена.
            this.документы_от_колледжаTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Документы_от_колледжа);

        }

        private void EditingCollegeDocumetsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
