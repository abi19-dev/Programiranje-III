namespace DLWMS.WinForms.IB220161
{
    partial class frmStudentSlike
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
            this.components = new System.ComponentModel.Container();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.desno = new System.Windows.Forms.Button();
            this.lijevo = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbStara = new System.Windows.Forms.PictureBox();
            this.pbNova = new System.Windows.Forms.PictureBox();
            this.lblRedniBroj = new System.Windows.Forms.Label();
            this.lblOpisTrenutno = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNova)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(233, 37);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(531, 94);
            this.tbOpis.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // desno
            // 
            this.desno.Location = new System.Drawing.Point(562, 307);
            this.desno.Name = "desno";
            this.desno.Size = new System.Drawing.Size(75, 23);
            this.desno.TabIndex = 2;
            this.desno.Text = "=>";
            this.desno.UseVisualStyleBackColor = true;
            this.desno.Click += new System.EventHandler(this.desno_Click);
            // 
            // lijevo
            // 
            this.lijevo.Location = new System.Drawing.Point(137, 307);
            this.lijevo.Name = "lijevo";
            this.lijevo.Size = new System.Drawing.Size(75, 23);
            this.lijevo.TabIndex = 2;
            this.lijevo.Text = "<=";
            this.lijevo.UseVisualStyleBackColor = true;
            this.lijevo.Click += new System.EventHandler(this.lijevo_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // pbStara
            // 
            this.pbStara.Location = new System.Drawing.Point(248, 195);
            this.pbStara.Name = "pbStara";
            this.pbStara.Size = new System.Drawing.Size(279, 243);
            this.pbStara.TabIndex = 0;
            this.pbStara.TabStop = false;
            // 
            // pbNova
            // 
            this.pbNova.Location = new System.Drawing.Point(26, 37);
            this.pbNova.Name = "pbNova";
            this.pbNova.Size = new System.Drawing.Size(100, 123);
            this.pbNova.TabIndex = 0;
            this.pbNova.TabStop = false;
            this.pbNova.Click += new System.EventHandler(this.pbNova_Click);
            // 
            // lblRedniBroj
            // 
            this.lblRedniBroj.AutoSize = true;
            this.lblRedniBroj.Location = new System.Drawing.Point(167, 159);
            this.lblRedniBroj.Name = "lblRedniBroj";
            this.lblRedniBroj.Size = new System.Drawing.Size(44, 16);
            this.lblRedniBroj.TabIndex = 3;
            this.lblRedniBroj.Text = "label1";
            // 
            // lblOpisTrenutno
            // 
            this.lblOpisTrenutno.AutoSize = true;
            this.lblOpisTrenutno.Location = new System.Drawing.Point(450, 159);
            this.lblOpisTrenutno.Name = "lblOpisTrenutno";
            this.lblOpisTrenutno.Size = new System.Drawing.Size(44, 16);
            this.lblOpisTrenutno.TabIndex = 3;
            this.lblOpisTrenutno.Text = "label1";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 409);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(44, 16);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "label1";
            // 
            // frmStudentSlike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblOpisTrenutno);
            this.Controls.Add(this.lblRedniBroj);
            this.Controls.Add(this.lijevo);
            this.Controls.Add(this.desno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.pbStara);
            this.Controls.Add(this.pbNova);
            this.Name = "frmStudentSlike";
            this.Text = "frmStudentSlike";
            this.Load += new System.EventHandler(this.frmStudentSlike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNova;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbStara;
        private System.Windows.Forms.Button desno;
        private System.Windows.Forms.Button lijevo;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label lblRedniBroj;
        private System.Windows.Forms.Label lblOpisTrenutno;
        private System.Windows.Forms.Label lblDatum;
    }
}