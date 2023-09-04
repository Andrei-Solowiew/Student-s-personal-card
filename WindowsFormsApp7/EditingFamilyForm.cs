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
    public partial class EditingFamilyForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public EditingFamilyForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Семья". При необходимости она может быть перемещена или удалена.
            this.семьяTableAdapter1.Fill(this.бД3DataSet.Семья);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Семья". При необходимости она может быть перемещена или удалена.
            this.семьяTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Семья);

        }

        private void EditingFamilyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void FamilyFormChangeComp_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKodStudentChange.Text);
            string query = "UPDATE Семья SET [Полная ли семья] = '" + textBoxUpdateToday.Text + "' WHERE [Код семьи] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Значение обновлено");
            this.семьяTableAdapter1.Fill(this.бД3DataSet.Семья);
        }

        private void FamilyFormChangeReason_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKodFamily1.Text);
            string query = "UPDATE Семья SET [Причина неполноты семьи] = '" + textBoxReason.Text + "' WHERE [Код семьи] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Причина обновлена");
            this.семьяTableAdapter1.Fill(this.бД3DataSet.Семья);
        }

        private void ChangeChildren_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod3.Text);
            string query = "UPDATE Семья SET [Количество детей] = '" + textBoxChildren.Text + "' WHERE [Код семьи] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Количество обновлено");
            this.семьяTableAdapter1.Fill(this.бД3DataSet.Семья);
        }

        private void ChangeChildrenDate_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod4.Text);
            string query = "UPDATE Семья SET [Дата рождения каждого] = '" + textBoxChildrenDate.Text + "' WHERE [Код семьи] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дата обновлена");
            this.семьяTableAdapter1.Fill(this.бД3DataSet.Семья);
        }

        private void ChangePlace_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod5.Text);
            string query = "UPDATE Семья SET [Где живут(дом, квартира)] = '" + textBoxPlace.Text + "' WHERE [Код семьи] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Значение обновлено");
            this.семьяTableAdapter1.Fill(this.бД3DataSet.Семья);
        }

        private void ChangeToday_Click(object sender, EventArgs e)
        {
            string data = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
            string query = $"UPDATE Семья SET[Сегодняшняя дата] = '{data}'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дата обновлена");
            this.семьяTableAdapter1.Fill(this.бД3DataSet.Семья);
        }

        private void textBoxUpdateToday_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
