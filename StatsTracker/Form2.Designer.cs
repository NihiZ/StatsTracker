namespace StatsTracker
{
    partial class Form2
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
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtListItem = new System.Windows.Forms.TextBox();
            this.cmbLists = new System.Windows.Forms.ComboBox();
            this.lbList = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddOrRemove = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(33, 500);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateDB.TabIndex = 0;
            this.btnUpdateDB.Text = "Update Database";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(33, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtListItem
            // 
            this.txtListItem.Location = new System.Drawing.Point(33, 364);
            this.txtListItem.Name = "txtListItem";
            this.txtListItem.Size = new System.Drawing.Size(188, 20);
            this.txtListItem.TabIndex = 10;
            this.txtListItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbLists
            // 
            this.cmbLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLists.FormattingEnabled = true;
            this.cmbLists.Items.AddRange(new object[] {
            "Projects",
            "Activities",
            "Software",
            "Assets"});
            this.cmbLists.Location = new System.Drawing.Point(33, 55);
            this.cmbLists.Name = "cmbLists";
            this.cmbLists.Size = new System.Drawing.Size(121, 21);
            this.cmbLists.TabIndex = 11;
            this.cmbLists.UseWaitCursor = true;
            this.cmbLists.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(33, 92);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(188, 186);
            this.lbList.TabIndex = 13;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(114, 390);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 23);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(30, 28);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(191, 13);
            this.lblList.TabIndex = 12;
            this.lblList.Text = "1 - Choose the list you want to change:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddOrRemove
            // 
            this.lblAddOrRemove.AutoSize = true;
            this.lblAddOrRemove.Location = new System.Drawing.Point(30, 336);
            this.lblAddOrRemove.Name = "lblAddOrRemove";
            this.lblAddOrRemove.Size = new System.Drawing.Size(196, 13);
            this.lblAddOrRemove.TabIndex = 15;
            this.lblAddOrRemove.Text = "2 - Type in new or remove selected Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "3 - Save or discard changes";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddOrRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.cmbLists);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.txtListItem);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateDB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtListItem;
        private System.Windows.Forms.ComboBox cmbLists;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddOrRemove;
        private System.Windows.Forms.Label label1;
    }
}