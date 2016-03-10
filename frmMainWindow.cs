using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using Agenda.Classes;

namespace Agenda
{
    public partial class MainWindowForm : Form
    {
        bool bModified = false;

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
            ReadData();
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
            if (!Regex.IsMatch(tbTelephone.Text.ToString(), @"^\d+$") && tbTelephone.Text != "")
            {
                MessageBox.Show("Only numbers allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTelephone.Text = "";
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
            if (strName.Length > 0)
            {
                if (strTel.Length == 10)
                {
                    dgViewAgenda.Rows.Add(strName, strTel);
                }
                else
                {
                    MessageBox.Show("The phone number must be 10 digit in length.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The phone number must be 10 digit in length.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!bModified)
            {
                bModified = true;
                btnValidateChanges.Enabled = true;
            }
            tbName.Text = "";
            tbTelephone.Text = "";
        }

        private void btnValidateChanges_Click(object sender, EventArgs e)
        {
            //dgViewAgenda.ReadOnly = true;
            ////btnValidateChanges.Enabled = false;
            //btnAddEntry.Enabled = true;
            //btnRemoveEntry.Enabled = true;
            using (XmlWriter writer = XmlWriter.Create("outputAgenda.xml"))
            {
                writer.WriteStartDocument();
                    writer.WriteStartElement("Agenda");
                foreach ( DataGridViewRow row in dgViewAgenda.Rows)
                {
                    try
                    {
                        if (row.Index < dgViewAgenda.Rows.Count - 2)
                        {
                            writer.WriteStartElement("entry");
                            writer.WriteElementString("name", row.Cells[0].Value.ToString());
                            writer.WriteElementString("tel", row.Cells[1].Value.ToString());
                            writer.WriteEndElement();
                        }
                    }
                    catch (Exception ex)
                    {
                        lblInfo.Text = ex.Message.ToString();
                    }
                }
                    writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row?", "Delete row", MessageBoxButtons.YesNo) == DialogResult.Yes && dgViewAgenda.Rows.Count != dgViewAgenda.SelectedRows.Count)
            {
                if (dgViewAgenda.SelectedRows.Count != 0)
                {
                    foreach (DataGridViewRow row in dgViewAgenda.SelectedRows)
                    {
                        dgViewAgenda.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else if (dgViewAgenda.Rows.Count <= 1)
            {
                MessageBox.Show("Could not delete an empty row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgViewAgenda_Click(object sender, EventArgs e)
        {

        }

        private void dgViewAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReadData()
        {
            XmlTextReader reader = new XmlTextReader(@"C:\git\Agenda\Agenda\Resources\patrutaa.xml");

            string name = null;
            string tel = null;
            reader.MoveToContent();

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element
                    && reader.Name == "entry")
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element
                            && reader.Name == "name")
                        {
                            name = reader.ReadString();
                            break;
                        }
                    }
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element
                            && reader.Name == "tel")
                        {
                            tel = reader.ReadString();
                            break;
                        }
                    }
                    dgViewAgenda.Rows.Add(name, tel);
                }
            }
        }

        private void dgViewAgenda_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgViewAgenda_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            btnAddEntry.Enabled = true;
        }

        private void dgViewAgenda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgViewAgenda_SelectionChanged(object sender, EventArgs e)
        {
            btnRemoveEntry.Enabled = true;
        }

        private void dgViewAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgViewAgenda.Rows[index].Selected = true;
        }
    }
}
