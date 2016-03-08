using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Agenda
{
    public partial class MainWindowForm : Form
    {

        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;
        

        public MainWindowForm()
        {
            InitializeComponent();
            btnAddEntry.Enabled = false;
            btnApplyFilter.Enabled = false;
            btnRemoveEntry.Enabled = false;
            btnValidateChanges.Enabled = false;
            tbTelephone.Enabled = false;
            
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData() {
            string strConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbAgenda.mdf;Integrated Security=True";
            string sql = "SELECT * FROM Agenda";

            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Agenda");
            sTable = sDs.Tables["Agenda"];
            dgViewAgenda.DataSource = sDs.Tables["Agenda"];
            dgViewAgenda.ReadOnly = true;
            dgViewAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0)
            {
                tbTelephone.Enabled = true;
            }
            else
            {
                tbTelephone.Enabled = false;
            }
            
        }

        private void tbTelephone_TextChanged(object sender, EventArgs e)
        {
            if (tbTelephone.Text.Length == 10)
            {
                btnAddEntry.Enabled = true;
            }
        }

        private void tbName_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
        }

        private void tbTelephone_Click(object sender, EventArgs e)
        {
            tbTelephone.Text = "";
        }

        private void tbInputFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbInputFilter.Text.Length > 0)
            {
                btnApplyFilter.Enabled = true;
            }
        }

        private void tbInputFilter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            string strName = tbName.Text;
            string strTel = tbTelephone.Text;

            DataGridViewRow row = (DataGridViewRow)dgViewAgenda.Rows[0].Clone();
            row.Cells[1].Value = strName;
            row.Cells[2].Value = strTel;
            dgViewAgenda.Rows.Add(row);

        }

        private void btnValidateChanges_Click(object sender, EventArgs e)
        {
            sAdapter.Update(sTable);
            dgViewAgenda.ReadOnly = true;
            btnValidateChanges.Enabled = false;
            btnAddEntry.Enabled = true;
            btnRemoveEntry.Enabled = true;
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row?", "Delete row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgViewAgenda.Rows.RemoveAt(dgViewAgenda.SelectedRows[0].Index);
                sAdapter.Update(sTable);
            }
        }

        private void dgViewAgenda_Click(object sender, EventArgs e)
        {
            if (dgViewAgenda.SelectedRows[0].Selected)
            {
                btnRemoveEntry.Enabled = true;
            }
        }
    }
}
