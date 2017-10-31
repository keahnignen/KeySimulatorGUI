namespace KeySimulatorGUI.View
{
    partial class PatternEdit
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
            this.lblPattername = new System.Windows.Forms.Label();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstKeys = new System.Windows.Forms.ListBox();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.grpSelectedItem = new System.Windows.Forms.GroupBox();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpSelectedItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPattername
            // 
            this.lblPattername.AutoSize = true;
            this.lblPattername.Location = new System.Drawing.Point(12, 23);
            this.lblPattername.Name = "lblPattername";
            this.lblPattername.Size = new System.Drawing.Size(76, 13);
            this.lblPattername.TabIndex = 0;
            this.lblPattername.Text = "[Pattern-name]";
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(413, 12);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(125, 33);
            this.btnChangeName.TabIndex = 4;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(346, 52);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(125, 33);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(137, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 33);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstKeys
            // 
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.Location = new System.Drawing.Point(12, 52);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.Size = new System.Drawing.Size(322, 186);
            this.lstKeys.TabIndex = 8;
            this.lstKeys.SelectedIndexChanged += new System.EventHandler(this.lstKeys_SelectedIndexChanged);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(477, 52);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(125, 33);
            this.btnRemoveAll.TabIndex = 9;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // grpSelectedItem
            // 
            this.grpSelectedItem.Controls.Add(this.btnRemove);
            this.grpSelectedItem.Enabled = false;
            this.grpSelectedItem.Location = new System.Drawing.Point(340, 91);
            this.grpSelectedItem.Name = "grpSelectedItem";
            this.grpSelectedItem.Size = new System.Drawing.Size(274, 63);
            this.grpSelectedItem.TabIndex = 11;
            this.grpSelectedItem.TabStop = false;
            this.grpSelectedItem.Text = "Option for selected  Item";
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(413, 205);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(125, 33);
            this.btnUse.TabIndex = 12;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(346, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 33);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(477, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // PatternEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 252);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.grpSelectedItem);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.lstKeys);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.lblPattername);
            this.Name = "PatternEdit";
            this.Text = "PatternEdit";
            this.grpSelectedItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPattername;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstKeys;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.GroupBox grpSelectedItem;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
    }
}