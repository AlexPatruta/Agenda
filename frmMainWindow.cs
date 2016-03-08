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

        }

        private void btnValidateChanges_Click(object sender, EventArgs e)
        {
            dgViewAgenda.ReadOnly = true;
            btnValidateChanges.Enabled = false;
            btnAddEntry.Enabled = true;
            btnRemoveEntry.Enabled = true;
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row?", "Delete row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            
            }
        }

        private void dgViewAgenda_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dgViewAgenda.SelectedRows[0].Selected)
            //    {
            //        btnRemoveEntry.Enabled = true;
            //    }
            //}
            //catch {
            //    MessageBox.Show("No data coulb be found in order to fill the agenda.", "Warning");
            //}
        }

        private void dgViewAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
