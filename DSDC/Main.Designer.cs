namespace DSDC
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbDeaths = new System.Windows.Forms.TextBox();
            this.tUpdate = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFile = new System.Windows.Forms.TextBox();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.tStatus = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txbDeaths
            // 
            this.txbDeaths.BackColor = System.Drawing.Color.Black;
            this.txbDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbDeaths.ForeColor = System.Drawing.Color.Red;
            this.txbDeaths.Location = new System.Drawing.Point(176, 12);
            this.txbDeaths.Name = "txbDeaths";
            this.txbDeaths.ReadOnly = true;
            this.txbDeaths.Size = new System.Drawing.Size(51, 31);
            this.txbDeaths.TabIndex = 2;
            // 
            // tUpdate
            // 
            this.tUpdate.Tick += new System.EventHandler(this.tUpdate_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deaths:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File:";
            // 
            // txbFile
            // 
            this.txbFile.BackColor = System.Drawing.Color.Black;
            this.txbFile.ForeColor = System.Drawing.Color.White;
            this.txbFile.Location = new System.Drawing.Point(44, 52);
            this.txbFile.Name = "txbFile";
            this.txbFile.ReadOnly = true;
            this.txbFile.Size = new System.Drawing.Size(341, 20);
            this.txbFile.TabIndex = 1;
            // 
            // sfdFile
            // 
            this.sfdFile.FileName = "DSDCout.txt";
            this.sfdFile.Filter = "Text files|*.txt|All files|*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DS Status:";
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.Black;
            this.txbStatus.ForeColor = System.Drawing.Color.White;
            this.txbStatus.Location = new System.Drawing.Point(76, 81);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(94, 20);
            this.txbStatus.TabIndex = 0;
            this.txbStatus.Text = "NOT running";
            // 
            // tStatus
            // 
            this.tStatus.Tick += new System.EventHandler(this.tStatus_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(397, 106);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDeaths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Dark Souls Death Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDeaths;
        private System.Windows.Forms.Timer tUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Timer tStatus;
    }
}

