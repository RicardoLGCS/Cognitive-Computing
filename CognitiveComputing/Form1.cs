using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace CognitiveComputing
{
    public partial class Form1 : Form
    {
        public static ListView table;
        public static int itotalFaults;
        public static int itotalUnresolvedFaults;
        private string[] getData = new string[6];
        private ListViewItem lv;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = faultTable;
            loadLog();
            itotalFaults = faultTable.Items.Count;
            countUnresolved();
        }

        private void logANewFaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newFaultWindow = new NewFaultForm();
            newFaultWindow.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoBox ib = new InfoBox();
            ib.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void countUnresolved()
        {
            var i = 0;
            foreach(ListViewItem item in faultTable.Items)
            {
                if (item.SubItems[6].Text == "Not Resolved")
                    i++;
            }
            itotalUnresolvedFaults = i;
        }

        private void getUnresolved()
        {
            string sReturn = "Return to normal table";
            string sSelectAllUnresolved = "Select all Unresolved";
            if (selectAllUnresolvedToolStripMenuItem.Text == "Select all Unresolved")
            {
                selectAllUnresolvedToolStripMenuItem.Text = sReturn;
                selectAllUnresolvedToolStripMenuItem1.Text = sReturn;
                foreach (ListViewItem item in faultTable.Items)
                {
                    if (item.SubItems[6].Text == "Resolved")
                    {
                        item.ForeColor = Color.Gray;
                    }
                    else
                    {
                        item.ForeColor = Color.White;
                        item.BackColor = Color.Maroon;
                    }
                }
            }
            else
            {
                selectAllUnresolvedToolStripMenuItem.Text = sSelectAllUnresolved;
                selectAllUnresolvedToolStripMenuItem1.Text = sSelectAllUnresolved;
                foreach (ListViewItem item in faultTable.Items)
                {
                    if (item.SubItems[6].Text == "Resolved")
                    {
                        item.ForeColor = Color.Black;
                    }
                    else
                    {
                        item.ForeColor = Color.Black;
                        item.BackColor = Color.White;
                    }
                }
            }
        }

        private void selectAllUnresolvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getUnresolved();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics();
            st.ShowDialog();
        }

        private void loadLog()
        {
            var file = File.ReadLines("fault.txt");
            string[] sData;
            foreach (string line in file)
            {
                sData = line.Split(',');
                lv = new ListViewItem(sData[0]);
                for(int i = 1; i < sData.Length; i++)
                    lv.SubItems.Add(sData[i]);
                faultTable.Items.Add(lv);
                sData = null;
            }
        }

        private void saveLogAs()
        {
            var subItemCount = faultTable.Columns.Count;
            getData = new string[subItemCount];
            try
            {
                //Creates the file fault.txt
                using (StreamWriter wr = new StreamWriter("fault.txt"))
                {
                    //For each item in the listview executes a loop for the subitems and then write them to the fault.txt
                    foreach (ListViewItem lvi in faultTable.Items)
                    {
                        for (int i = 0; i < subItemCount; i++)
                        {
                            getData[i] = lvi.SubItems[i].Text;
                        }
                        for(int y = 0; y<getData.Length; y++)
                        {
                            if(y == (getData.Length - 1))
                                wr.WriteLine(getData[y]);
                            else
                                wr.Write(getData[y] + ",");
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Something gone wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLogAs();
            MessageBox.Show("File saved with success!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveLogAs();
        }
    }
}
