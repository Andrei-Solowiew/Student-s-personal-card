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
    
    public partial class EditingNeedsForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public EditingNeedsForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Потребности_студента". При необходимости она может быть перемещена или удалена.
            this.потребности_студентаTableAdapter1.Fill(this.бД3DataSet.Потребности_студента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Родители". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter.Fill(this.бД3DataSet.Родители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Потребности_студента". При необходимости она может быть перемещена или удалена.
            this.потребности_студентаTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Потребности_студента);

        }

        private void EditingNeedsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxKodNeed.Text);
            string query = "UPDATE [Потребности студента] SET [Потребность в общежитии] = '" + checkBoxNeed.Text + "' WHERE [Код потребностей] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Специальность обновлена");
            this.потребности_студентаTableAdapter1.Fill(this.бД3DataSet.Потребности_студента);
        }
    }
}
