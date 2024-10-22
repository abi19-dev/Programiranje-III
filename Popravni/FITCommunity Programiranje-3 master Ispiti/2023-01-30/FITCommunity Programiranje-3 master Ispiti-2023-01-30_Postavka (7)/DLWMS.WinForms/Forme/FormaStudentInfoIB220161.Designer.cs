namespace DLWMS.WinForms.Forme
{
    partial class FormaStudentInfoIB220161
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
            pbStudent = new PictureBox();
            imePrezimeLbl = new Label();
            ProsjekLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pbStudent).BeginInit();
            SuspendLayout();
            // 
            // pbStudent
            // 
            pbStudent.Location = new Point(12, 12);
            pbStudent.Name = "pbStudent";
            pbStudent.Size = new Size(336, 352);
            pbStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStudent.TabIndex = 0;
            pbStudent.TabStop = false;
            // 
            // imePrezimeLbl
            // 
            imePrezimeLbl.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            imePrezimeLbl.Location = new Point(12, 367);
            imePrezimeLbl.Name = "imePrezimeLbl";
            imePrezimeLbl.Size = new Size(336, 60);
            imePrezimeLbl.TabIndex = 1;
            imePrezimeLbl.Text = "Ime i Prezime";
            imePrezimeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProsjekLbl
            // 
            ProsjekLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ProsjekLbl.Location = new Point(12, 427);
            ProsjekLbl.Name = "ProsjekLbl";
            ProsjekLbl.Size = new Size(336, 35);
            ProsjekLbl.TabIndex = 2;
            ProsjekLbl.Text = "Prosjek:";
            ProsjekLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormaStudentInfoIB220161
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 492);
            Controls.Add(ProsjekLbl);
            Controls.Add(imePrezimeLbl);
            Controls.Add(pbStudent);
            Name = "FormaStudentInfoIB220161";
            Text = "FormaStudentInfoIB220161";
            ((System.ComponentModel.ISupportInitialize)pbStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbStudent;
        private Label imePrezimeLbl;
        private Label ProsjekLbl;
    }
}