namespace KeySimulatorGUI
{
    partial class Patterns
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
            this.dgvPattern = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPattern)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPattern
            // 
            this.dgvPattern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPattern.Location = new System.Drawing.Point(12, 12);
            this.dgvPattern.Name = "dgvPattern";
            this.dgvPattern.Size = new System.Drawing.Size(630, 437);
            this.dgvPattern.TabIndex = 0;
            // 
            // Patterns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 466);
            this.Controls.Add(this.dgvPattern);
            this.Name = "Patterns";
            this.Text = "Patterns";
            this.Load += new System.EventHandler(this.Patterns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPattern)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPattern;
    }
}