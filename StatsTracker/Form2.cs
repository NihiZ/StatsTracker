using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsTracker
{
    public partial class Form2 : Form
    {
        // List containing all lists below
        List<List<string>> myLists = new List<List<string>>();

        List<string> projects = new List<string>();
        List<string> activities = new List<string>();
        List<string> software = new List<string>();
        List<string> assets = new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // Get needed Data from DBManager
            projects = DBManager.projects;
            activities = DBManager.activities;
            software = DBManager.software;
            assets = DBManager.assets;

            // add all temporary lists into the parent list
            myLists.Add(projects);
            myLists.Add(activities);
            myLists.Add(software);
            myLists.Add(assets);

            // Set default Combolist item (to projects)
            cmbLists.SelectedIndex = 0;


        }



        // Display correct list whenever the user chooses a list item
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cmbLists.SelectedIndex) {
                case 0:
                    lbList.Items.Clear();
                    lbList.Items.AddRange(projects.Cast<object>().ToArray());
                    break;
                case 1:
                    lbList.Items.Clear();
                    lbList.Items.AddRange(activities.Cast<object>().ToArray());
                    break;
                case 2:
                    lbList.Items.Clear();
                    lbList.Items.AddRange(software.Cast<object>().ToArray());
                    break;
                case 3:
                    lbList.Items.Clear();
                    lbList.Items.AddRange(assets.Cast<object>().ToArray());
                    break;
            }
            
        }


        // Activate / Deactivate Add Button whenever the TextBox is empty
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtListItem.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else {
                btnAdd.Enabled = false;
            }
        }

        // add item to the temporary list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get text from textbox
            string newItem = txtListItem.Text;
            bool isDuplicate = false;


            foreach (string s in lbList.Items)
            {
                if (s == txtListItem.Text)
                {
                    isDuplicate = true;
                }
            }

            if (!isDuplicate)
            {
                lbList.Items.Add(newItem);
            }
            else {
                MessageBox.Show("Item already exists.");
            }

            txtListItem.Text = "";
        }


        // Remove selected item from listbox
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int currentIndex = lbList.SelectedIndex;
            lbList.Items.RemoveAt(currentIndex);
        }


        private void btnUpdateDB_Click(object sender, EventArgs e) {
            DBManager.UpdateTables(myLists); // pass in the parent list
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
