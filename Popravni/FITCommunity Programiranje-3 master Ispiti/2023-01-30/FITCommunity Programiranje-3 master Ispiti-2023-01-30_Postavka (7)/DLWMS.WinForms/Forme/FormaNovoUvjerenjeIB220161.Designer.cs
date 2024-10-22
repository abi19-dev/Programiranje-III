namespace DLWMS.WinForms.Forme
{
    partial class FormaNovoUvjerenjeIB220161
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
            btnSacuvaj = new Button();
            cbVrsta = new ComboBox();
            tbSvrha = new TextBox();
            pbUplatnica = new PictureBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(660, 381);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(126, 29);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // cbVrsta
            // 
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Location = new Point(12, 66);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(290, 28);
            cbVrsta.TabIndex = 1;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(12, 117);
            tbSvrha.Multiline = true;
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(290, 293);
            tbSvrha.TabIndex = 2;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(381, 117);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(405, 258);
            pbUplatnica.TabIndex = 3;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // FormaNovoUvjerenjeIB220161
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbUplatnica);
            Controls.Add(tbSvrha);
            Controls.Add(cbVrsta);
            Controls.Add(btnSacuvaj);
            Name = "FormaNovoUvjerenjeIB220161";
            Text = "FormaNovoUvjerenjeIB220161";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private ComboBox cbVrsta;
        private TextBox tbSvrha;
        private PictureBox pbUplatnica;
        private ErrorProvider err;
    }
}