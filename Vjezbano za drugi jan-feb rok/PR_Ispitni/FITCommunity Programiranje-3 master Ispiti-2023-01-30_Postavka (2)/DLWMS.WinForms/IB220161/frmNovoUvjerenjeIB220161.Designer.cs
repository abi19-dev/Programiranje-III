namespace DLWMS.WinForms.IB220161
{
    partial class frmNovoUvjerenjeIB220161
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
            pbUplatnica = new PictureBox();
            btnSacuvaj = new Button();
            cmbVrsta = new ComboBox();
            tbSvrha = new TextBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(433, 58);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(552, 294);
            pbUplatnica.TabIndex = 0;
            pbUplatnica.TabStop = false;
            pbUplatnica.Click += pbUplatnica_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(871, 376);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(114, 29);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Location = new Point(12, 58);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(328, 28);
            cmbVrsta.TabIndex = 2;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(12, 147);
            tbSvrha.MinimumSize = new Size(0, 250);
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(328, 250);
            tbSvrha.TabIndex = 3;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovoUvjerenjeIB220161
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 450);
            Controls.Add(tbSvrha);
            Controls.Add(cmbVrsta);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Name = "frmNovoUvjerenjeIB220161";
            Text = "frmNovoUvjerenjeIB220161";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbUplatnica;
        private Button btnSacuvaj;
        private ComboBox cmbVrsta;
        private TextBox tbSvrha;
        private ErrorProvider err;
    }
}