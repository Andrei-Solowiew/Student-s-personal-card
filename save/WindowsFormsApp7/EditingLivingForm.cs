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
    public partial class EditingLivingForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public EditingLivingForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
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

        private void EditingLivingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void ChangeCity_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod1.Text);
            string query = "UPDATE [Место проживания студента] SET [Населенный пункт проживания] = '" + textBoxCity.Text + "' WHERE [Код проживания] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Населенный пункт обновлен");
            this.место_проживания_студентаTableAdapter1.Fill(this.бД3DataSet.Место_проживания_студента);
        }

        private void ChangeStreet_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod2.Text);
            string query = "UPDATE [Место проживания студента] SET Улица = '" + textBoxStreet.Text + "' WHERE [Код проживания] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Улица обновлен");
            this.место_проживания_студентаTableAdapter1.Fill(this.бД3DataSet.Место_проживания_студента);
        }

        private void ChangeHouse_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod3.Text);
            string query = "UPDATE [Место проживания студента] SET Дом = '" + textBoxHouse.Text + "' WHERE [Код проживания] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дом обновлен");
            this.место_проживания_студентаTableAdapter1.Fill(this.бД3DataSet.Место_проживания_студента);
        }

        private void ChangeFlat_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKod4.Text);
            string query = "UPDATE [Место проживания студента] SET Квартира = '" + textBoxFlat.Text + "' WHERE [Код проживания] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Квартира обновлена");
            this.место_проживания_студентаTableAdapter1.Fill(this.бД3DataSet.Место_проживания_студента);
        }
    }
}
