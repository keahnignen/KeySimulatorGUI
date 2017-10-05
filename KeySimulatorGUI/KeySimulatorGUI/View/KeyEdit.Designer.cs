namespace KeySimulatorGUI.View
{
    partial class KeyEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblKeyName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPressTime = new System.Windows.Forms.NumericUpDown();
            this.btnChangeKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPressTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // lblKeyName
            // 
            this.lblKeyName.AutoSize = true;
            this.lblKeyName.Location = new System.Drawing.Point(86, 13);
            this.lblKeyName.Name = "lblKeyName";
            this.lblKeyName.Size = new System.Drawing.Size(64, 13);
            this.lblKeyName.TabIndex = 1;
            this.lblKeyName.Text = "{Key Name}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Press-Time:";
            // 
            // nudPressTime
            // 
            this.nudPressTime.Location = new System.Drawing.Point(89, 93);
            this.nudPressTime.Name = "nudPressTime";
            this.nudPressTime.Size = new System.Drawing.Size(125, 20);
            this.nudPressTime.TabIndex = 3;
            this.nudPressTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChangeKey
            // 
            this.btnChangeKey.Location = new System.Drawing.Point(12, 38);
            this.btnChangeKey.Name = "btnChangeKey";
            this.btnChangeKey.Size = new System.Drawing.Size(202, 33);
            this.btnChangeKey.TabIndex = 21;
            this.btnChangeKey.Text = "Change Key";
            this.btnChangeKey.UseVisualStyleBackColor = true;
            this.btnChangeKey.Click += new System.EventHandler(this.btnChangeKey_Click);
            // 
            // KeyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 133);
            this.Controls.Add(this.btnChangeKey);
            this.Controls.Add(this.nudPressTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKeyName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KeyEdit";
            this.Text = "KeyEdit";
            ((System.ComponentModel.ISupportInitialize)(this.nudPressTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKeyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPressTime;
        private System.Windows.Forms.Button btnChangeKey;
    }
}