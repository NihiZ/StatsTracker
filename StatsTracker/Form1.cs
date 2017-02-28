using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StatsTracker
{


    public partial class Form1 : Form
    {

        public int defaultAmntPomos = 12;
        int currentAmount = 0;
        int pomoElementCounter = 0;

        public static List<Pomo> pomos = new List<Pomo>();


        public Form1()
        {
            InitializeComponent();

            // initialize number selector default value
            numAmntPomos.Value = defaultAmntPomos;
        }



        void DisplayPomos(int newAmount) {

            int difference = newAmount - currentAmount;
            // create pomo objects and put them in the list

            UpdatePomoList(difference);

            // Update before returning!
            currentAmount = pomos.Count;

            // First time adding pomos to the flowControl 
            if (flwPomos.Controls.Count == 0)
            {
                for (int i = 0; i < pomos.Count; i++)
                {
                    flwPomos.Controls.Add(pomos[i].lblName);
                    flwPomos.Controls.Add(pomos[i].cmbProject);
                    flwPomos.Controls.Add(pomos[i].cmbActivity);
                    flwPomos.Controls.Add(pomos[i].cmbSoftware);
                    flwPomos.Controls.Add(pomos[i].cmbAsset);


                    // we need a way to know how many Controls a pomo contains. we need this when removing pomos from flwPomos
                    if (pomoElementCounter == 0)
                    {
                        pomoElementCounter = flwPomos.Controls.Count;
                    }
                }
                return;
            }

            // we have to access the last difference (n) elements from the 'pomos' list and remove them
            if (difference > 0)
            {

                for (int i = (pomos.Count - difference); i < pomos.Count; i++) {
                    flwPomos.Controls.Add(pomos[i].lblName);
                    flwPomos.Controls.Add(pomos[i].cmbProject);
                    flwPomos.Controls.Add(pomos[i].cmbActivity);
                    flwPomos.Controls.Add(pomos[i].cmbSoftware);
                    flwPomos.Controls.Add(pomos[i].cmbAsset);

                }
            }
            else {
                for (int i = flwPomos.Controls.Count; i > (pomos.Count * pomoElementCounter); i--)
                    flwPomos.Controls.RemoveAt(i - 1);
            }


        }

        // adds / removes Pomo objects from the 'pomos' list pomos depending on difference
        private void UpdatePomoList(int difference)
        {
            if (difference > 0)
            {
                for (int i = 0; i < difference; i++)
                {
                    pomos.Add(new Pomo(pomos.Count + 1));
                }
            }
            else {
                for (int i = 0; i > difference; i--)
                {
                    pomos.RemoveAt(pomos.Count - 1);
                }
            }
            Console.WriteLine("Updating pomos List done. New Count:" + pomos.Count);
        }



        private void numAmntPomos_ValueChanged(object sender, EventArgs e)
        {
            DisplayPomos((int)numAmntPomos.Value);
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Save requested");
            // Call Method on DBManager to update Database
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("index changed");
        }

        private void btnManageLists_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
