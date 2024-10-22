namespace DLWMS.WinForms.IB220161
{
    partial class FrmNovoUvjerenjeIB220161
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
            cbVrsta = new ComboBox();
            tb = new TextBox();
            pictureBox1 = new PictureBox();
            btnSacuvaj = new Button();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // cbVrsta
            // 
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Uvjerenje o polozenim ispitima", "Uvjerenje o redovnom studiranju" });
            cbVrsta.Location = new Point(12, 63);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(270, 28);
            cbVrsta.TabIndex = 0;
            // 
            // tb
            // 
            tb.Location = new Point(12, 129);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.Size = new Size(270, 236);
            tb.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(346, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(694, 336);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(123, 29);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // FrmNovoUvjerenjeIB220161
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 377);
            Controls.Add(btnSacuvaj);
            Controls.Add(pictureBox1);
            Controls.Add(tb);
            Controls.Add(cbVrsta);
            Name = "FrmNovoUvjerenjeIB220161";
            Text = "FrmNovoUvjerenjeIB220161";
            Load += FrmNovoUvjerenjeIB220161_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbVrsta;
        private TextBox tb;
        private PictureBox pictureBox1;
        private Button btnSacuvaj;
        private ErrorProvider errProvider;
    }
}