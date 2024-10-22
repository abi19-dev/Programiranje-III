namespace DLWMS.WinForms.IB220161
{
    partial class frmUvjerenjaIzvjestajIB220161
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
            vrstaLbl = new Label();
            svrhaLbl = new Label();
            cbVrste = new ComboBox();
            tbSvrha = new TextBox();
            pbUplatnica = new PictureBox();
            uplatnicaLbl = new Label();
            sacuvajBtn = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // vrstaLbl
            // 
            vrstaLbl.AutoSize = true;
            vrstaLbl.Location = new Point(42, 50);
            vrstaLbl.Name = "vrstaLbl";
            vrstaLbl.Size = new Size(108, 20);
            vrstaLbl.TabIndex = 0;
            vrstaLbl.Text = "Vrsta uvjerenja:";
            // 
            // svrhaLbl
            // 
            svrhaLbl.AutoSize = true;
            svrhaLbl.Location = new Point(42, 104);
            svrhaLbl.Name = "svrhaLbl";
            svrhaLbl.Size = new Size(112, 20);
            svrhaLbl.TabIndex = 0;
            svrhaLbl.Text = "Svrha uvjerenja:";
            // 
            // cbVrste
            // 
            cbVrste.FormattingEnabled = true;
            cbVrste.Location = new Point(42, 73);
            cbVrste.Name = "cbVrste";
            cbVrste.Size = new Size(261, 28);
            cbVrste.TabIndex = 1;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(42, 127);
            tbSvrha.Multiline = true;
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(261, 311);
            tbSvrha.TabIndex = 2;
            // 
            // pbUplatnica
            // 
            pbUplatnica.BorderStyle = BorderStyle.FixedSingle;
            pbUplatnica.Location = new Point(352, 73);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(436, 330);
            pbUplatnica.TabIndex = 3;
            pbUplatnica.TabStop = false;
            pbUplatnica.Click += pbUplatnica_Click;
            // 
            // uplatnicaLbl
            // 
            uplatnicaLbl.AutoSize = true;
            uplatnicaLbl.Location = new Point(352, 50);
            uplatnicaLbl.Name = "uplatnicaLbl";
            uplatnicaLbl.Size = new Size(141, 20);
            uplatnicaLbl.TabIndex = 0;
            uplatnicaLbl.Text = "Skenirana uplatnica:";
            // 
            // sacuvajBtn
            // 
            sacuvajBtn.Location = new Point(694, 409);
            sacuvajBtn.Name = "sacuvajBtn";
            sacuvajBtn.Size = new Size(94, 29);
            sacuvajBtn.TabIndex = 4;
            sacuvajBtn.Text = "Sačuvaj";
            sacuvajBtn.UseVisualStyleBackColor = true;
            sacuvajBtn.Click += sacuvajBtn_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmUvjerenjaIzvjestajIB220161
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sacuvajBtn);
            Controls.Add(pbUplatnica);
            Controls.Add(tbSvrha);
            Controls.Add(cbVrste);
            Controls.Add(svrhaLbl);
            Controls.Add(uplatnicaLbl);
            Controls.Add(vrstaLbl);
            Name = "frmUvjerenjaIzvjestajIB220161";
            Text = "frmUvjerenjaIzvjestajIB220161";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label vrstaLbl;
        private Label svrhaLbl;
        private ComboBox cbVrste;
        private TextBox tbSvrha;
        private PictureBox pbUplatnica;
        private Label uplatnicaLbl;
        private Button sacuvajBtn;
        private ErrorProvider err;
    }
}