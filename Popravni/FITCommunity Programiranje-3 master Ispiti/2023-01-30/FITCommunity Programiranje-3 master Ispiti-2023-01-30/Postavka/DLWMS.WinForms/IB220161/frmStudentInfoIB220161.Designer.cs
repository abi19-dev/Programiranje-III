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
            pbStudent = new PictureBox();
            studentLbl = new Label();
            ProsjekLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pbStudent).BeginInit();
            SuspendLayout();
            // 
            // pbStudent
            // 
            pbStudent.Location = new Point(22, 22);
            pbStudent.Name = "pbStudent";
            pbStudent.Size = new Size(360, 377);
            pbStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStudent.TabIndex = 0;
            pbStudent.TabStop = false;
            // 
            // studentLbl
            // 
            studentLbl.AutoSize = true;
            studentLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            studentLbl.Location = new Point(98, 411);
            studentLbl.Name = "studentLbl";
            studentLbl.Size = new Size(200, 46);
            studentLbl.TabIndex = 1;
            studentLbl.Text = "Denis Mušić";
            // 
            // ProsjekLbl
            // 
            ProsjekLbl.AutoSize = true;
            ProsjekLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProsjekLbl.Location = new Point(156, 457);
            ProsjekLbl.Name = "ProsjekLbl";
            ProsjekLbl.Size = new Size(75, 28);
            ProsjekLbl.TabIndex = 1;
            ProsjekLbl.Text = "Prosjek";
            // 
            // frmStudentInfoIB220161
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 509);
            Controls.Add(ProsjekLbl);
            Controls.Add(studentLbl);
            Controls.Add(pbStudent);
            Name = "frmStudentInfoIB220161";
            Text = "frmStudentInfoIB220161";
            Load += frmStudentInfoIB220161_Load;
            ((System.ComponentModel.ISupportInitialize)pbStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbStudent;
        private Label studentLbl;
        private Label ProsjekLbl;
    }
}