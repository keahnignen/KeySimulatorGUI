namespace KeySimulatorGUI.View
{
    partial class OrderEditor
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
            this.btnAddKey = new System.Windows.Forms.Button();
            this.btnAddDelay = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.nudPressTime = new System.Windows.Forms.NumericUpDown();
            this.lblPressTime = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdoAfter = new System.Windows.Forms.RadioButton();
            this.rdoBefore = new System.Windows.Forms.RadioButton();
            this.rdoStart = new System.Windows.Forms.RadioButton();
            this.grpAddPoint = new System.Windows.Forms.GroupBox();
            this.rdoEnd = new System.Windows.Forms.RadioButton();
            this.lblPatternName = new System.Windows.Forms.Label();
            this.grpOptionSelectedItem = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPressTime)).BeginInit();
            this.grpAddPoint.SuspendLayout();
            this.grpOptionSelectedItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(12, 99);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(387, 420);
            this.lstLog.TabIndex = 0;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(12, 60);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(125, 33);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnAddKey
            // 
            this.btnAddKey.Location = new System.Drawing.Point(143, 60);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(125, 33);
            this.btnAddKey.TabIndex = 2;
            this.btnAddKey.Text = "Add Key";
            this.btnAddKey.UseVisualStyleBackColor = true;
            // 
            // btnAddDelay
            // 
            this.btnAddDelay.Location = new System.Drawing.Point(274, 60);
            this.btnAddDelay.Name = "btnAddDelay";
            this.btnAddDelay.Size = new System.Drawing.Size(125, 33);
            this.btnAddDelay.TabIndex = 3;
            this.btnAddDelay.Text = "Add Delay";
            this.btnAddDelay.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(556, 449);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(125, 33);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(556, 488);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(542, 20);
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
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(6, 58);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(125, 33);
            this.btnMoveUp.TabIndex = 14;
            this.btnMoveUp.Text = "Move ↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // nudDelay
            // 
            this.nudDelay.Location = new System.Drawing.Point(405, 68);
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(271, 20);
            this.nudDelay.TabIndex = 17;
            this.nudDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudPressTime
            // 
            this.nudPressTime.Location = new System.Drawing.Point(137, 97);
            this.nudPressTime.Name = "nudPressTime";
            this.nudPressTime.Size = new System.Drawing.Size(125, 20);
            this.nudPressTime.TabIndex = 18;
            this.nudPressTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPressTime
            // 
            this.lblPressTime.AutoSize = true;
            this.lblPressTime.Location = new System.Drawing.Point(43, 99);
            this.lblPressTime.Name = "lblPressTime";
            this.lblPressTime.Size = new System.Drawing.Size(62, 13);
            this.lblPressTime.TabIndex = 19;
            this.lblPressTime.Text = "Press Time:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 488);
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
            this.rdoBefore.Location = new System.Drawing.Point(131, 16);
            this.rdoBefore.Name = "rdoBefore";
            this.rdoBefore.Size = new System.Drawing.Size(122, 17);
            this.rdoBefore.TabIndex = 22;
            this.rdoBefore.Text = "Before selected Item";
            this.rdoBefore.UseVisualStyleBackColor = true;
            // 
            // rdoStart
            // 
            this.rdoStart.AutoSize = true;
            this.rdoStart.Location = new System.Drawing.Point(262, 16);
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
            this.grpAddPoint.Location = new System.Drawing.Point(12, 12);
            this.grpAddPoint.Name = "grpAddPoint";
            this.grpAddPoint.Size = new System.Drawing.Size(524, 42);
            this.grpAddPoint.TabIndex = 24;
            this.grpAddPoint.TabStop = false;
            this.grpAddPoint.Text = "Add point:";
            // 
            // rdoEnd
            // 
            this.rdoEnd.AutoSize = true;
            this.rdoEnd.Location = new System.Drawing.Point(393, 16);
            this.rdoEnd.Name = "rdoEnd";
            this.rdoEnd.Size = new System.Drawing.Size(74, 17);
            this.rdoEnd.TabIndex = 24;
            this.rdoEnd.Text = "At the end";
            this.rdoEnd.UseVisualStyleBackColor = true;
            // 
            // lblPatternName
            // 
            this.lblPatternName.AutoSize = true;
            this.lblPatternName.Location = new System.Drawing.Point(553, 276);
            this.lblPatternName.Name = "lblPatternName";
            this.lblPatternName.Size = new System.Drawing.Size(70, 13);
            this.lblPatternName.TabIndex = 25;
            this.lblPatternName.Text = "Pattern name";
            // 
            // grpOptionSelectedItem
            // 
            this.grpOptionSelectedItem.Controls.Add(this.btnEdit);
            this.grpOptionSelectedItem.Controls.Add(this.btnRemove);
            this.grpOptionSelectedItem.Controls.Add(this.btnMoveUp);
            this.grpOptionSelectedItem.Controls.Add(this.btnMoveDown);
            this.grpOptionSelectedItem.Controls.Add(this.lblPressTime);
            this.grpOptionSelectedItem.Controls.Add(this.nudPressTime);
            this.grpOptionSelectedItem.Location = new System.Drawing.Point(405, 94);
            this.grpOptionSelectedItem.Name = "grpOptionSelectedItem";
            this.grpOptionSelectedItem.Size = new System.Drawing.Size(271, 124);
            this.grpOptionSelectedItem.TabIndex = 26;
            this.grpOptionSelectedItem.TabStop = false;
            this.grpOptionSelectedItem.Text = "Options of selected Item";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 33);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // OrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 533);
            this.Controls.Add(this.grpOptionSelectedItem);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.lblPatternName);
            this.Controls.Add(this.grpAddPoint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudDelay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAddDelay);
            this.Controls.Add(this.btnAddKey);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.lstLog);
            this.Name = "OrderEditor";
            this.Text = "Order Editor";
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPressTime)).EndInit();
            this.grpAddPoint.ResumeLayout(false);
            this.grpAddPoint.PerformLayout();
            this.grpOptionSelectedItem.ResumeLayout(false);
            this.grpOptionSelectedItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.Button btnAddDelay;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.NumericUpDown nudPressTime;
        private System.Windows.Forms.Label lblPressTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdoAfter;
        private System.Windows.Forms.RadioButton rdoBefore;
        private System.Windows.Forms.RadioButton rdoStart;
        private System.Windows.Forms.GroupBox grpAddPoint;
        private System.Windows.Forms.RadioButton rdoEnd;
        private System.Windows.Forms.Label lblPatternName;
        private System.Windows.Forms.GroupBox grpOptionSelectedItem;
        private System.Windows.Forms.Button btnEdit;
    }
}