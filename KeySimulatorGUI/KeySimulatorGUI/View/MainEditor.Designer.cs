namespace KeySimulatorGUI.View
{
    partial class MainEditor
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
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnAddDelay = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdoAfter = new System.Windows.Forms.RadioButton();
            this.rdoBefore = new System.Windows.Forms.RadioButton();
            this.rdoStart = new System.Windows.Forms.RadioButton();
            this.grpAddPoint = new System.Windows.Forms.GroupBox();
            this.rdoEnd = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpOptionSelectedItem = new System.Windows.Forms.GroupBox();
            this.btnEditSelectedItem = new System.Windows.Forms.Button();
            this.grpPattern = new System.Windows.Forms.GroupBox();
            this.grpSelectedOrderOptions = new System.Windows.Forms.GroupBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudInitalDelay = new System.Windows.Forms.NumericUpDown();
            this.nudDelayBetween = new System.Windows.Forms.NumericUpDown();
            this.lblDelayBetween = new System.Windows.Forms.Label();
            this.lblInitalDelay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.grpAddPoint.SuspendLayout();
            this.grpOptionSelectedItem.SuspendLayout();
            this.grpPattern.SuspendLayout();
            this.grpSelectedOrderOptions.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.grpName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitalDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayBetween)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(14, 410);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(256, 420);
            this.lstLog.TabIndex = 0;
            this.lstLog.SelectedIndexChanged += new System.EventHandler(this.lstLog_SelectedIndexChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(10, 19);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(125, 33);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Start Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(10, 86);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(125, 33);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnAddDelay
            // 
            this.btnAddDelay.Location = new System.Drawing.Point(10, 58);
            this.btnAddDelay.Name = "btnAddDelay";
            this.btnAddDelay.Size = new System.Drawing.Size(125, 33);
            this.btnAddDelay.TabIndex = 3;
            this.btnAddDelay.Text = "Add Delay";
            this.btnAddDelay.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(413, 755);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(125, 33);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 794);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(413, 323);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(125, 33);
            this.btnRemoveAll.TabIndex = 13;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(137, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 33);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(137, 58);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(125, 33);
            this.btnMoveDown.TabIndex = 15;
            this.btnMoveDown.Text = "Move ↓";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(6, 58);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(125, 33);
            this.btnMoveUp.TabIndex = 14;
            this.btnMoveUp.Text = "Move ↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // nudDelay
            // 
            this.nudDelay.Location = new System.Drawing.Point(146, 66);
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(125, 20);
            this.nudDelay.TabIndex = 17;
            this.nudDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(282, 794);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 33);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // rdoAfter
            // 
            this.rdoAfter.AutoSize = true;
            this.rdoAfter.Checked = true;
            this.rdoAfter.Location = new System.Drawing.Point(6, 16);
            this.rdoAfter.Name = "rdoAfter";
            this.rdoAfter.Size = new System.Drawing.Size(113, 17);
            this.rdoAfter.TabIndex = 21;
            this.rdoAfter.TabStop = true;
            this.rdoAfter.Text = "After selected Item";
            this.rdoAfter.UseVisualStyleBackColor = true;
            // 
            // rdoBefore
            // 
            this.rdoBefore.AutoSize = true;
            this.rdoBefore.Location = new System.Drawing.Point(137, 16);
            this.rdoBefore.Name = "rdoBefore";
            this.rdoBefore.Size = new System.Drawing.Size(122, 17);
            this.rdoBefore.TabIndex = 22;
            this.rdoBefore.Text = "Before selected Item";
            this.rdoBefore.UseVisualStyleBackColor = true;
            // 
            // rdoStart
            // 
            this.rdoStart.AutoSize = true;
            this.rdoStart.Location = new System.Drawing.Point(274, 16);
            this.rdoStart.Name = "rdoStart";
            this.rdoStart.Size = new System.Drawing.Size(76, 17);
            this.rdoStart.TabIndex = 23;
            this.rdoStart.Text = "At the start";
            this.rdoStart.UseVisualStyleBackColor = true;
            // 
            // grpAddPoint
            // 
            this.grpAddPoint.Controls.Add(this.rdoEnd);
            this.grpAddPoint.Controls.Add(this.rdoAfter);
            this.grpAddPoint.Controls.Add(this.rdoStart);
            this.grpAddPoint.Controls.Add(this.rdoBefore);
            this.grpAddPoint.Location = new System.Drawing.Point(8, 70);
            this.grpAddPoint.Name = "grpAddPoint";
            this.grpAddPoint.Size = new System.Drawing.Size(539, 42);
            this.grpAddPoint.TabIndex = 24;
            this.grpAddPoint.TabStop = false;
            this.grpAddPoint.Text = "Add point:";
            // 
            // rdoEnd
            // 
            this.rdoEnd.AutoSize = true;
            this.rdoEnd.Location = new System.Drawing.Point(405, 16);
            this.rdoEnd.Name = "rdoEnd";
            this.rdoEnd.Size = new System.Drawing.Size(74, 17);
            this.rdoEnd.TabIndex = 24;
            this.rdoEnd.Text = "At the end";
            this.rdoEnd.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 20);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Name:";
            // 
            // grpOptionSelectedItem
            // 
            this.grpOptionSelectedItem.Controls.Add(this.btnEditSelectedItem);
            this.grpOptionSelectedItem.Controls.Add(this.btnRemove);
            this.grpOptionSelectedItem.Controls.Add(this.btnMoveUp);
            this.grpOptionSelectedItem.Controls.Add(this.btnMoveDown);
            this.grpOptionSelectedItem.Enabled = false;
            this.grpOptionSelectedItem.Location = new System.Drawing.Point(276, 410);
            this.grpOptionSelectedItem.Name = "grpOptionSelectedItem";
            this.grpOptionSelectedItem.Size = new System.Drawing.Size(270, 96);
            this.grpOptionSelectedItem.TabIndex = 26;
            this.grpOptionSelectedItem.TabStop = false;
            this.grpOptionSelectedItem.Text = "Options of selected Item";
            // 
            // btnEditSelectedItem
            // 
            this.btnEditSelectedItem.Location = new System.Drawing.Point(6, 19);
            this.btnEditSelectedItem.Name = "btnEditSelectedItem";
            this.btnEditSelectedItem.Size = new System.Drawing.Size(125, 33);
            this.btnEditSelectedItem.TabIndex = 20;
            this.btnEditSelectedItem.Text = "Edit";
            this.btnEditSelectedItem.UseVisualStyleBackColor = true;
            this.btnEditSelectedItem.Click += new System.EventHandler(this.btnEditSelectedItem_Click);
            // 
            // grpPattern
            // 
            this.grpPattern.Controls.Add(this.lblInitalDelay);
            this.grpPattern.Controls.Add(this.lblDelayBetween);
            this.grpPattern.Controls.Add(this.nudDelayBetween);
            this.grpPattern.Controls.Add(this.nudInitalDelay);
            this.grpPattern.Controls.Add(this.grpSelectedOrderOptions);
            this.grpPattern.Controls.Add(this.cmbOrder);
            this.grpPattern.Controls.Add(this.btnNewOrder);
            this.grpPattern.Location = new System.Drawing.Point(8, 118);
            this.grpPattern.Name = "grpPattern";
            this.grpPattern.Size = new System.Drawing.Size(538, 163);
            this.grpPattern.TabIndex = 31;
            this.grpPattern.TabStop = false;
            this.grpPattern.Text = "Controls for edit pattern";
            // 
            // grpSelectedOrderOptions
            // 
            this.grpSelectedOrderOptions.Controls.Add(this.btnAddOrder);
            this.grpSelectedOrderOptions.Controls.Add(this.btnEditOrder);
            this.grpSelectedOrderOptions.Enabled = false;
            this.grpSelectedOrderOptions.Location = new System.Drawing.Point(260, 19);
            this.grpSelectedOrderOptions.Name = "grpSelectedOrderOptions";
            this.grpSelectedOrderOptions.Size = new System.Drawing.Size(272, 61);
            this.grpSelectedOrderOptions.TabIndex = 35;
            this.grpSelectedOrderOptions.TabStop = false;
            this.grpSelectedOrderOptions.Text = "Options";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(137, 19);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(125, 33);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(6, 19);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(125, 33);
            this.btnEditOrder.TabIndex = 33;
            this.btnEditOrder.Text = "Edit";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(10, 45);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(244, 21);
            this.cmbOrder.TabIndex = 3;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.btnRecord);
            this.grpOrder.Controls.Add(this.btnAddDelay);
            this.grpOrder.Controls.Add(this.nudDelay);
            this.grpOrder.Location = new System.Drawing.Point(8, 304);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(277, 100);
            this.grpOrder.TabIndex = 32;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Controls for edit order";
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(442, 28);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(109, 17);
            this.chkName.TabIndex = 33;
            this.chkName.Text = "Enable to rename";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkName_CheckedChanged);
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtName);
            this.grpName.Controls.Add(this.lblTitle);
            this.grpName.Location = new System.Drawing.Point(8, 12);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(428, 42);
            this.grpName.TabIndex = 34;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 30;
            // 
            // nudInitalDelay
            // 
            this.nudInitalDelay.Location = new System.Drawing.Point(397, 91);
            this.nudInitalDelay.Name = "nudInitalDelay";
            this.nudInitalDelay.Size = new System.Drawing.Size(125, 20);
            this.nudInitalDelay.TabIndex = 36;
            this.nudInitalDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudDelayBetween
            // 
            this.nudDelayBetween.Location = new System.Drawing.Point(397, 117);
            this.nudDelayBetween.Name = "nudDelayBetween";
            this.nudDelayBetween.Size = new System.Drawing.Size(125, 20);
            this.nudDelayBetween.TabIndex = 37;
            this.nudDelayBetween.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDelayBetween
            // 
            this.lblDelayBetween.AutoSize = true;
            this.lblDelayBetween.Location = new System.Drawing.Point(271, 119);
            this.lblDelayBetween.Name = "lblDelayBetween";
            this.lblDelayBetween.Size = new System.Drawing.Size(78, 13);
            this.lblDelayBetween.TabIndex = 38;
            this.lblDelayBetween.Text = "Delay between";
            // 
            // lblInitalDelay
            // 
            this.lblInitalDelay.AutoSize = true;
            this.lblInitalDelay.Location = new System.Drawing.Point(271, 93);
            this.lblInitalDelay.Name = "lblInitalDelay";
            this.lblInitalDelay.Size = new System.Drawing.Size(59, 13);
            this.lblInitalDelay.TabIndex = 39;
            this.lblInitalDelay.Text = "Inital Delay";
            // 
            // MainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 847);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.chkName);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpPattern);
            this.Controls.Add(this.grpOptionSelectedItem);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.grpAddPoint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lstLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainEditor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.MainEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.grpAddPoint.ResumeLayout(false);
            this.grpAddPoint.PerformLayout();
            this.grpOptionSelectedItem.ResumeLayout(false);
            this.grpPattern.ResumeLayout(false);
            this.grpPattern.PerformLayout();
            this.grpSelectedOrderOptions.ResumeLayout(false);
            this.grpOrder.ResumeLayout(false);
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitalDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayBetween)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnAddDelay;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdoAfter;
        private System.Windows.Forms.RadioButton rdoBefore;
        private System.Windows.Forms.RadioButton rdoStart;
        private System.Windows.Forms.GroupBox grpAddPoint;
        private System.Windows.Forms.RadioButton rdoEnd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpOptionSelectedItem;
        private System.Windows.Forms.Button btnEditSelectedItem;
        private System.Windows.Forms.GroupBox grpPattern;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpSelectedOrderOptions;
        private System.Windows.Forms.Label lblInitalDelay;
        private System.Windows.Forms.Label lblDelayBetween;
        private System.Windows.Forms.NumericUpDown nudDelayBetween;
        private System.Windows.Forms.NumericUpDown nudInitalDelay;
    }
}