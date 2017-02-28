using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsTracker
{
    public class Pomo
    {
        // container class representing a single pomos data

        public int index;
        public Label lblName;
        public ComboBox cmbProject;
        public ComboBox cmbActivity;
        public ComboBox cmbSoftware;
        public ComboBox cmbAsset;

        public Pomo(int number) {

            index = number;

            lblName = new Label();
            lblName.Text = "Pomo: " + number;

            cmbProject = new ComboBox();
            cmbProject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProject.Items.AddRange(DBManager.projects.ToArray());
            cmbProject.SelectedIndexChanged += cmbProject_SelectedIndexChanged;

            cmbActivity = new ComboBox();
            cmbActivity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivity.Items.AddRange(DBManager.activities.ToArray());

            cmbSoftware = new ComboBox();
            cmbSoftware.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSoftware.Items.AddRange(DBManager.software.ToArray());

            cmbAsset = new ComboBox();
            cmbAsset.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAsset.Items.AddRange(DBManager.assets.ToArray());
        }

        // Eventhandler that automatically changes the chosen value to the same on all consecutive project Comboboxes
        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // we iterate through all pomos in the pomos List and compare the index of all pomos with 'this' pomo
            foreach (Pomo p in Form1.pomos) {
                if (index < p.index) {
                    p.cmbProject.SelectedIndex = cmbProject.SelectedIndex;

                }
            }
            
        }
    }
}
