using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMAIN;

namespace FeedBUF_Casus.Forms
{
    public partial class TeacherForm : Form
    {
        public List<Panel> panels = new List<Panel>();

        public TeacherForm()
        {
            InitializeComponent();
            panels.Add(pnlFeedback);
            panels.Add(pnlFeedup);
            panels.Add(pnlHome);
            panels.Add(pnlConclusie);
        }

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            cbxPanelSwitch.SelectedIndex = -1;
            HidePanels();
            pnlHome.Show();
        }
    }
}
