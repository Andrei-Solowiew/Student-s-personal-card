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

    public partial class EditingRegistrationForm : Form
    {

        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public EditingRegistrationForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Место_регистрации_студента". При необходимости она может быть перемещена или удалена.
            this.место_регистрации_студентаTableAdapter1.Fill(this.бД3DataSet.Место_регистрации_студента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Место_регистрации_студента". При необходимости она может быть перемещена или удалена.
            this.место_регистрации_студентаTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Место_регистрации_студента);

        }

        private void EditingRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void ChangeCity_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod1.Text);
            string query = "UPDATE [Место регистрации студента] SET [Населенный пункт регистрации] = '" + textBoxCity.Text + "' WHERE [Код регистрации] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Населенный пункт обновлен");
            this.место_регистрации_студентаTableAdapter1.Fill(this.бД3DataSet.Место_регистрации_студента);
        }

        private void ChangeStreet_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod2.Text);
            string query = "UPDATE [Место регистрации студента] SET Улица = '" + textBoxStreet.Text + "' WHERE [Код регистрации] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Улица обновлена");
            this.место_регистрации_студентаTableAdapter1.Fill(this.бД3DataSet.Место_регистрации_студента);
        }

        private void ChangeHouse_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod3.Text);
            string query = "UPDATE [Место регистрации студента] SET Дом = '" + textBoxHouse.Text + "' WHERE [Код регистрации] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дом обновлен");
            this.место_регистрации_студентаTableAdapter1.Fill(this.бД3DataSet.Место_регистрации_студента);
        }

        private void ChangeFlat_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod4.Text);
            string query = "UPDATE [Место регистрации студента] SET Квартира = '" + textBoxFlat.Text + "' WHERE [Код регистрации] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Квартира обновлена");
            this.место_регистрации_студентаTableAdapter1.Fill(this.бД3DataSet.Место_регистрации_студента);
        }
    }
}
