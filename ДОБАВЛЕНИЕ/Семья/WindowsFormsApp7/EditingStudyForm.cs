using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace WindowsFormsApp7
{
    public partial class EditingStudyForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public EditingStudyForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Обучение_студента". При необходимости она может быть перемещена или удалена.
            this.обучение_студентаTableAdapter1.Fill(this.бД3DataSet.Обучение_студента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Обучение_студента". При необходимости она может быть перемещена или удалена.
            this.обучение_студентаTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Обучение_студента);

        }

        private void EditingStudyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void ChangeForm_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod1.Text);
            string query = "UPDATE [Обучение студента] SET [Форма обучения] = '" + textBoxForm.Text + "' WHERE [Код обучения] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Форма обновлена");
            this.обучение_студентаTableAdapter1.Fill(this.бД3DataSet.Обучение_студента);
        }

        private void ChangeFormat_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod2.Text);
            string query = "UPDATE [Обучение студента] SET [Формат обучения] = '" + textBoxFormat.Text + "' WHERE [Код обучения] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Формат обновлен");
            this.обучение_студентаTableAdapter1.Fill(this.бД3DataSet.Обучение_студента);
        }

        private void ChangeGroup_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod3.Text);
            string query = "UPDATE [Обучение студента] SET Группа = '" + textBoxGroup.Text + "' WHERE [Код обучения] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Группа обновлена");
            this.обучение_студентаTableAdapter1.Fill(this.бД3DataSet.Обучение_студента);
        }

        private void ChangeTerm_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod4.Text);
            string query = "UPDATE [Обучение студента] SET [Срок обучения] = '" + textBoxTerm.Text + "' WHERE [Код обучения] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Срок обновлен");
            this.обучение_студентаTableAdapter1.Fill(this.бД3DataSet.Обучение_студента);
        }
    }
}
