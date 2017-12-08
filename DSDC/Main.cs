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
using System.Security.Principal;

namespace DSDC
{
    public partial class Main : Form
    {
        private DSMiner dsm;
        int lastDeath = -1, currDeath = 0;
        string filePath;
        bool isAdmin;

        public Main()
        {
            InitializeComponent();

            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!isAdmin)
            {
                MessageBox.Show("Run this program 'as admin'");
                Environment.Exit(1);
            }


            txbDeaths.TextAlign = HorizontalAlignment.Center;

            dsm = new DSMiner("DATA");
              
            if(sfdFile.ShowDialog() == DialogResult.OK)
            {
                filePath = sfdFile.FileName;

                txbFile.Text = filePath;
            }

            tStatus.Start();
            tUpdate.Start();

        }

        private void tStatus_Tick(object sender, EventArgs e)
        {
            if (dsm.isProcessRunning())
            {
                if (!dsm.isAttached())
                {
                    dsm.Attach();
                    txbStatus.Text = "Running";
                    txbStatus.ForeColor = Color.Green;
                }
            }
            else
            {
                dsm.Detach();
                txbStatus.Text = "NOT Running";
                txbStatus.ForeColor = Color.Red;
            }
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
