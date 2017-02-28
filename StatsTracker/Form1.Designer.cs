namespace StatsTracker
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.numAmntPomos = new System.Windows.Forms.NumericUpDown();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flwPomos = new System.Windows.Forms.FlowLayoutPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnManageLists = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAmntPomos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 524);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save to Database";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(15, 28);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(123, 13);
            this.lblStep1.TabIndex = 6;
            this.lblStep1.Text = "1 - Choose correct Date:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit StatsTracker";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Location = new System.Drawing.Point(15, 100);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(165, 13);
            this.lblStep2.TabIndex = 9;
            this.lblStep2.Text = "2 - How many Pomos did you do?";
            // 
            // numAmntPomos
            // 
            this.numAmntPomos.Location = new System.Drawing.Point(15, 130);
            this.numAmntPomos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmntPomos.Name = "numAmntPomos";
            this.numAmntPomos.Size = new System.Drawing.Size(120, 20);
            this.numAmntPomos.TabIndex = 10;
            this.numAmntPomos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmntPomos.ValueChanged += new System.EventHandler(this.numAmntPomos_ValueChanged);
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.Location = new System.Drawing.Point(287, 28);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(183, 13);
            this.lblStep3.TabIndex = 11;
            this.lblStep3.Text = "3 - Set according data for each pomo";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(18, 59);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // flwPomos
            // 
            this.flwPomos.Location = new System.Drawing.Point(290, 84);
            this.flwPomos.Name = "flwPomos";
            this.flwPomos.Size = new System.Drawing.Size(622, 428);
            this.flwPomos.TabIndex = 13;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnManageLists
            // 
            this.btnManageLists.Location = new System.Drawing.Point(504, 23);
            this.btnManageLists.Name = "btnManageLists";
            this.btnManageLists.Size = new System.Drawing.Size(104, 23);
            this.btnManageLists.TabIndex = 0;
            this.btnManageLists.Text = "Manage Lists";
            this.btnManageLists.UseVisualStyleBackColor = true;
            this.btnManageLists.Click += new System.EventHandler(this.btnManageLists_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 559);
            this.Controls.Add(this.btnManageLists);
            this.Controls.Add(this.flwPomos);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.numAmntPomos);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAmntPomos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.NumericUpDown numAmntPomos;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.FlowLayoutPanel flwPomos;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnManageLists;
    }
}

