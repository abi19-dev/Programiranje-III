namespace FIT.WinForms.IB220024WinForms
{
    partial class frmNovaDrzavaIB220024
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
            components = new System.ComponentModel.Container();
            pcbZastava = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNaziv = new TextBox();
            chbAktivna = new CheckBox();
            btnSavucaj = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pcbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pcbZastava
            // 
            pcbZastava.BackColor = SystemColors.GrayText;
            pcbZastava.Location = new Point(12, 29);
            pcbZastava.Name = "pcbZastava";
            pcbZastava.Size = new Size(317, 142);
            pcbZastava.SizeMode = PictureBoxSizeMode.Zoom;
            pcbZastava.TabIndex = 0;
            pcbZastava.TabStop = false;
            pcbZastava.DoubleClick += pcbZastava_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Zastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Naziv";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 196);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(317, 23);
            txtNaziv.TabIndex = 3;
            // 
            // chbAktivna
            // 
            chbAktivna.AutoSize = true;
            chbAktivna.Location = new Point(12, 225);
            chbAktivna.Name = "chbAktivna";
            chbAktivna.Size = new Size(66, 19);
            chbAktivna.TabIndex = 4;
            chbAktivna.Text = "Aktivna";
            chbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSavucaj
            // 
            btnSavucaj.Location = new Point(254, 244);
            btnSavucaj.Name = "btnSavucaj";
            btnSavucaj.Size = new Size(75, 23);
            btnSavucaj.TabIndex = 5;
            btnSavucaj.Text = "Sacuvaj";
            btnSavucaj.UseVisualStyleBackColor = true;
            btnSavucaj.Click += btnSavucaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaDrzavaIB220024
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 281);
            Controls.Add(btnSavucaj);
            Controls.Add(chbAktivna);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pcbZastava);
            Name = "frmNovaDrzavaIB220024";
            Text = "Podaci o državi";
            Load += frmNovaDrzavaIB220024_Load;
            ((System.ComponentModel.ISupportInitialize)pcbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbZastava;
        private Label label1;
        private Label label2;
        private TextBox txtNaziv;
        private CheckBox chbAktivna;
        private Button btnSavucaj;
        private ErrorProvider err;
    }
}