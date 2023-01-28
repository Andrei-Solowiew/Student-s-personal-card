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
    public partial class EditingParentsForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public EditingParentsForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Родители". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter1.Fill(this.бД3DataSet.Родители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Родители". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Родители);

        }

        private void EditingParentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void ChangeMomWork_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod1.Text);
            string query = "UPDATE Родители SET [Место работы матери] = '" + textBoxMomWork.Text + "' WHERE [Код родителей] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Место работы обновлено");
            this.родителиTableAdapter1.Fill(this.бД3DataSet.Родители);
        }

        private void ChangeMomPost_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod2.Text);
            string query = "UPDATE Родители SET [Должность матери] = '" + textBoxMomPost.Text + "' WHERE [Код родителей] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Должность обновлена");
            this.родителиTableAdapter1.Fill(this.бД3DataSet.Родители);
        }

        private void ChangePapaWork_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod3.Text);
            string query = "UPDATE Родители SET [Место работы отца] = '" + textBoxPapaWork.Text + "' WHERE [Код родителей] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Работа обновлена");
            this.родителиTableAdapter1.Fill(this.бД3DataSet.Родители);
        }

        private void ChangePapaPost_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod4.Text);
            string query = "UPDATE Родители SET [Должность отца] = '" + textBoxPapaPost.Text + "' WHERE [Код родителей] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Должность обновлена");
            this.родителиTableAdapter1.Fill(this.бД3DataSet.Родители);
        }

        private void ChangeZpWork_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod5.Text);
            string query = "UPDATE Родители SET [Место работы зп] = '" + textBoxZpWork.Text + "' WHERE [Код родителей] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Работа обновлена");
            this.родителиTableAdapter1.Fill(this.бД3DataSet.Родители);
        }

        private void ChangeZpPost_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod6.Text);
            string query = "UPDATE Родители SET [Должность зп] = '" + textBoxZpPost.Text + "' WHERE [Код родителей] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Должность обновлена");
            this.родителиTableAdapter1.Fill(this.бД3DataSet.Родители);
        }
    }
}
