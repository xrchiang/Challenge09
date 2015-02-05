namespace Challenge9 {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmdCalc = new System.Windows.Forms.Button();
            this.txtValues = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdCalc
            // 
            this.cmdCalc.Location = new System.Drawing.Point(12, 9);
            this.cmdCalc.Name = "cmdCalc";
            this.cmdCalc.Size = new System.Drawing.Size(75, 23);
            this.cmdCalc.TabIndex = 0;
            this.cmdCalc.Text = "Calc";
            this.cmdCalc.UseVisualStyleBackColor = true;
            this.cmdCalc.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(104, 12);
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(321, 20);
            this.txtValues.TabIndex = 1;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(104, 46);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(209, 134);
            this.lstResults.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 192);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.txtValues);
            this.Controls.Add(this.cmdCalc);
            this.Name = "frmMain";
            this.Text = "Challenge 9 - Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCalc;
        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.ListBox lstResults;
    }
}

