namespace KeySimulatorGUI.View
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstPatternSelector = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpPatternOption = new System.Windows.Forms.GroupBox();
            this.rtxPatternProperties = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.chkEnableSuperDelete = new System.Windows.Forms.CheckBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeletePatterns = new System.Windows.Forms.Button();
            this.chkDisableDeleteConfimation = new System.Windows.Forms.CheckBox();
            this.chkEnableDelete = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.grpPatternOption.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.listToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New (Ctrl+N)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit (Alt+F4)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lstPatternSelector
            // 
            this.lstPatternSelector.FormattingEnabled = true;
            this.lstPatternSelector.Location = new System.Drawing.Point(41, 39);
            this.lstPatternSelector.Name = "lstPatternSelector";
            this.lstPatternSelector.Size = new System.Drawing.Size(387, 238);
            this.lstPatternSelector.TabIndex = 0;
            this.lstPatternSelector.SelectedValueChanged += new System.EventHandler(this.lstPatternSelector_SelectedValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(303, 286);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(125, 33);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(6, 259);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(125, 33);
            this.btnUse.TabIndex = 1;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(137, 258);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpPatternOption
            // 
            this.grpPatternOption.Controls.Add(this.rtxPatternProperties);
            this.grpPatternOption.Controls.Add(this.btnDelete);
            this.grpPatternOption.Controls.Add(this.btnEdit);
            this.grpPatternOption.Controls.Add(this.btnUse);
            this.grpPatternOption.Enabled = false;
            this.grpPatternOption.Location = new System.Drawing.Point(434, 27);
            this.grpPatternOption.Name = "grpPatternOption";
            this.grpPatternOption.Size = new System.Drawing.Size(401, 297);
            this.grpPatternOption.TabIndex = 7;
            this.grpPatternOption.TabStop = false;
            this.grpPatternOption.Text = "Pattern Selection";
            // 
            // rtxPatternProperties
            // 
            this.rtxPatternProperties.Location = new System.Drawing.Point(6, 15);
            this.rtxPatternProperties.Name = "rtxPatternProperties";
            this.rtxPatternProperties.ReadOnly = true;
            this.rtxPatternProperties.Size = new System.Drawing.Size(387, 238);
            this.rtxPatternProperties.TabIndex = 5;
            this.rtxPatternProperties.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(268, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.chkEnableSuperDelete);
            this.grpDelete.Controls.Add(this.btnDeleteAll);
            this.grpDelete.Controls.Add(this.btnDeletePatterns);
            this.grpDelete.Controls.Add(this.chkDisableDeleteConfimation);
            this.grpDelete.Location = new System.Drawing.Point(41, 342);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(794, 48);
            this.grpDelete.TabIndex = 8;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete";
            // 
            // chkEnableSuperDelete
            // 
            this.chkEnableSuperDelete.AutoSize = true;
            this.chkEnableSuperDelete.Location = new System.Drawing.Point(393, 19);
            this.chkEnableSuperDelete.Name = "chkEnableSuperDelete";
            this.chkEnableSuperDelete.Size = new System.Drawing.Size(120, 17);
            this.chkEnableSuperDelete.TabIndex = 4;
            this.chkEnableSuperDelete.Text = "Enable super delete";
            this.chkEnableSuperDelete.UseVisualStyleBackColor = true;
            this.chkEnableSuperDelete.CheckedChanged += new System.EventHandler(this.chkEnableToDelteAll_CheckedChanged);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(661, 10);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(125, 33);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeletePatterns
            // 
            this.btnDeletePatterns.Location = new System.Drawing.Point(530, 10);
            this.btnDeletePatterns.Name = "btnDeletePatterns";
            this.btnDeletePatterns.Size = new System.Drawing.Size(125, 33);
            this.btnDeletePatterns.TabIndex = 2;
            this.btnDeletePatterns.Text = "Delete Patterns";
            this.btnDeletePatterns.UseVisualStyleBackColor = true;
            this.btnDeletePatterns.Click += new System.EventHandler(this.btnDeletePattern_Click);
            // 
            // chkDisableDeleteConfimation
            // 
            this.chkDisableDeleteConfimation.AutoSize = true;
            this.chkDisableDeleteConfimation.Location = new System.Drawing.Point(6, 19);
            this.chkDisableDeleteConfimation.Name = "chkDisableDeleteConfimation";
            this.chkDisableDeleteConfimation.Size = new System.Drawing.Size(153, 17);
            this.chkDisableDeleteConfimation.TabIndex = 1;
            this.chkDisableDeleteConfimation.Text = "Disable delete confirmation";
            this.chkDisableDeleteConfimation.UseVisualStyleBackColor = true;
            // 
            // chkEnableDelete
            // 
            this.chkEnableDelete.AutoSize = true;
            this.chkEnableDelete.Location = new System.Drawing.Point(47, 319);
            this.chkEnableDelete.Name = "chkEnableDelete";
            this.chkEnableDelete.Size = new System.Drawing.Size(103, 17);
            this.chkEnableDelete.TabIndex = 0;
            this.chkEnableDelete.Text = "Enable to delete";
            this.chkEnableDelete.UseVisualStyleBackColor = true;
            this.chkEnableDelete.CheckedChanged += new System.EventHandler(this.chkEnableDelete_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 402);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpPatternOption);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstPatternSelector);
            this.Controls.Add(this.chkEnableDelete);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "KeySimulatorGUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPatternOption.ResumeLayout(false);
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox lstPatternSelector;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpPatternOption;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDeletePatterns;
        private System.Windows.Forms.CheckBox chkDisableDeleteConfimation;
        private System.Windows.Forms.CheckBox chkEnableDelete;
        private System.Windows.Forms.RichTextBox rtxPatternProperties;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.CheckBox chkEnableSuperDelete;
    }
}

