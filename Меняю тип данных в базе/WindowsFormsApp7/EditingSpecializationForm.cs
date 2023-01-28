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
    public partial class EditingSpecializationForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=СР-5_ОПБД_Соловьев_Андрей_П9021.mdb";
        private OleDbConnection myConnection;
        public EditingSpecializationForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Специальность);

        }

        private void EditingSpecializationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();

        }

        private void SpecualizationFormChange_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKodStudentChange.Text);
            string query = "UPDATE Специальность SET Специальность = '" + textBoxUpdateToday.Text + "' WHERE [Код специальности] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Специальность обновлена");
            this.специальностьTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Специальность);
        }
    }
}
