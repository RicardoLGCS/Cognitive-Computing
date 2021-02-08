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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            double itotalFaults = Form1.itotalFaults;
            double itotalUnresolvedFaults = Form1.itotalUnresolvedFaults;
            double ipercentageUnresolvedFaults = ((itotalUnresolvedFaults / itotalFaults) * 100);
            label1.Text = itotalFaults.ToString();
            label2.Text = itotalUnresolvedFaults.ToString();
            label3.Text = ipercentageUnresolvedFaults.ToString() + "%";
        }
    }
}
