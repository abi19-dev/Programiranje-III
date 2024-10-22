namespace DLWMS.WinForms.IB220161
{
    partial class frmStudentInfoIB220161
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
            pbSlika = new PictureBox();
            nazivStudenta = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(62, 28);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(310, 329);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // nazivStudenta
            // 
            nazivStudenta.AutoSize = true;
            nazivStudenta.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nazivStudenta.Location = new Point(107, 384);
            nazivStudenta.Name = "nazivStudenta";
            nazivStudenta.Size = new Size(222, 46);
            nazivStudenta.TabIndex = 1;
            nazivStudenta.Text = "Ime i prezime";
            nazivStudenta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(181, 444);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(56, 20);
            lblProsjek.TabIndex = 2;
            lblProsjek.Text = "Prosjek";
            lblProsjek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentInfoIB220161
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 515);
            Controls.Add(lblProsjek);
            Controls.Add(nazivStudenta);
            Controls.Add(pbSlika);
            Name = "frmStudentInfoIB220161";
            Text = "frmStudentInfoIB220161";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label nazivStudenta;
        private Label lblProsjek;
    }
}