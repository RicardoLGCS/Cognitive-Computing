using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CognitiveComputing
{
    public partial class NewFaultForm : Form
    {
        private string[] newFaultData = new string[6];
        public NewFaultForm()
        {
            InitializeComponent();
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.Empty == txtCompanyName.Text)
            {
                MessageBox.Show("Company Name field can't be empty", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (string.Empty == txtContactNumber.Text)
            {
                MessageBox.Show("Contact Number field can't be empty", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (string.Empty == txtDescription.Text)
            {
                MessageBox.Show("Description field can't be empty", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(cbxFaultType.SelectedItem == null)
            {
                MessageBox.Show("You must choose a fault type", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(cbxStatus.SelectedItem == null)
            {
                MessageBox.Show("You must choose a status", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (cbxThreatLevel.SelectedItem == null)
            {
                MessageBox.Show("You must choose a threat level", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
                newFaultData[0] = txtCompanyName.Text;
                newFaultData[1] = txtContactNumber.Text;
                newFaultData[2] = cbxFaultType.SelectedItem.ToString();
                newFaultData[3] = txtDescription.Text;
                newFaultData[4] = cbxThreatLevel.SelectedItem.ToString(); 
                newFaultData[5] = cbxStatus.SelectedItem.ToString();
                insertNewFault();
                Form1.itotalFaults = Form1.table.Items.Count;
                if (cbxStatus.SelectedIndex == 1)
                    Form1.itotalUnresolvedFaults = Form1.itotalUnresolvedFaults + 1;
            }
        }

        public void insertNewFault()
        {
            ListViewItem lv = new ListViewItem((Form1.table.Items.Count + 1).ToString());
            foreach (string data in newFaultData)
            {
                lv.SubItems.Add(data);
            }
            Form1.table.Items.Add(lv);
        }

        private void NewFaultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
