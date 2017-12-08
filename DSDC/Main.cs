using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace DSDC
{
    public partial class Main : Form
    {
        private DSMiner dsm;
        int lastDeath = -1, currDeath = 0;
        string filePath;


        public Main()
        {
            InitializeComponent();

            txbDeaths.TextAlign = HorizontalAlignment.Center;

            bool found = false;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    dsm = new DSMiner("DATA");
                    found = true;
                    break;
                }
                catch { }

                Thread.Sleep(500);
            }

            if (!found)
            {
                MessageBox.Show("Dark Souls is not running.");
                Environment.Exit(1);
            }

            if(sfdFile.ShowDialog() == DialogResult.OK)
            {
                filePath = sfdFile.FileName;

                txbFile.Text = filePath;
                
                
            }

            tUpdate.Start();
        }

        private void tUpdate_Tick(object sender, EventArgs e)
        {
            if (dsm.isProcessRunning())
            {
                currDeath = dsm.readDeaths();

                txbDeaths.Text = currDeath + "";


                if(currDeath != lastDeath && currDeath != -1)
                {
                    try
                    {
                        File.WriteAllText(filePath, currDeath + "");
                    }
                    catch { }

                    lastDeath = currDeath;
                }

            } else
            {
                txbDeaths.Text = "-1";
            }
        }
    }
}
