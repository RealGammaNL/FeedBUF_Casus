using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;
using System.Windows.Forms;

namespace FeedBUF_Casus.Forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            panels.Add(pnlFeedback);
            panels.Add(pnlFeedforward);
            panels.Add(pnlFeedup);
            panels.Add(pnlConclusion);
        }

        public List<Panel> panels = new List<Panel>() { };
        // aanpassen met de panels in de form

        private void Switchpanel(object sender, EventArgs e)
        {
            string selectedChoice = cbxPanelSwitch.Text;
            string selectedPnl = "pnl" + selectedChoice;

            HidePanels();
            foreach (Panel panel in panels)
            {
                if (panel.Name == selectedPnl)
                {
                    panel.Show();
                }
            }
        }

        private void HidePanels()
        {
            foreach (Panel p in panels)
            {
                p.Hide();
            }
        }
    }
}
