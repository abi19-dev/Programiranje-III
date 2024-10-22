namespace FIT.WinForms.IB220024WinForms
{
    partial class frmGradoviIB220024
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
            lblDrzavaNaziv = new Label();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            PromjeniStatus = new DataGridViewButtonColumn();
            label1 = new Label();
            txtNazivGrada = new TextBox();
            btnDodaj = new Button();
            err = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtBrojGradova = new TextBox();
            chbAktivan = new CheckBox();
            btnGenerisi = new Button();
            label3 = new Label();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pcbZastava
            // 
            pcbZastava.Location = new Point(18, 22);
            pcbZastava.Name = "pcbZastava";
            pcbZastava.Size = new Size(135, 86);
            pcbZastava.SizeMode = PictureBoxSizeMode.Zoom;
            pcbZastava.TabIndex = 0;
            pcbZastava.TabStop = false;
            // 
            // lblDrzavaNaziv
            // 
            lblDrzavaNaziv.AutoSize = true;
            lblDrzavaNaziv.Font = new Font("Segoe UI", 29F, FontStyle.Bold);
            lblDrzavaNaziv.Location = new Point(159, 44);
            lblDrzavaNaziv.Name = "lblDrzavaNaziv";
            lblDrzavaNaziv.Size = new Size(264, 52);
            lblDrzavaNaziv.TabIndex = 1;
            lblDrzavaNaziv.Text = "Naziv Drzave";
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.AllowUserToOrderColumns = true;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, PromjeniStatus });
            dgvGradovi.Location = new Point(12, 160);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.RowTemplate.Height = 25;
            dgvGradovi.Size = new Size(570, 150);
            dgvGradovi.TabIndex = 2;
            dgvGradovi.CellClick += dgvGradovi_CellClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv Grada";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // PromjeniStatus
            // 
            PromjeniStatus.HeaderText = "";
            PromjeniStatus.Name = "PromjeniStatus";
            PromjeniStatus.Text = "Promjeni status";
            PromjeniStatus.UseColumnTextForButtonValue = true;
            PromjeniStatus.Width = 214;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 3;
            label1.Text = "Unesite naziv novog grada: ";
            // 
            // txtNazivGrada
            // 
            txtNazivGrada.Location = new Point(170, 129);
            txtNazivGrada.Name = "txtNazivGrada";
            txtNazivGrada.Size = new Size(331, 23);
            txtNazivGrada.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(507, 131);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(chbAktivan);
            groupBox1.Controls.Add(txtBrojGradova);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 333);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 214);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Broj gradova: ";
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(92, 34);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(84, 23);
            txtBrojGradova.TabIndex = 1;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Location = new Point(182, 36);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(66, 19);
            chbAktivan.TabIndex = 2;
            chbAktivan.Text = "Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(254, 34);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 62);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "Info";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(9, 80);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(555, 128);
            txtInfo.TabIndex = 5;
            // 
            // frmGradoviIB220024
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 559);
            Controls.Add(groupBox1);
            Controls.Add(btnDodaj);
            Controls.Add(txtNazivGrada);
            Controls.Add(label1);
            Controls.Add(dgvGradovi);
            Controls.Add(lblDrzavaNaziv);
            Controls.Add(pcbZastava);
            Name = "frmGradoviIB220024";
            Text = "Podaci o gradu";
            Load += frmGradoviIB220024_Load;
            ((System.ComponentModel.ISupportInitialize)pcbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbZastava;
        private Label lblDrzavaNaziv;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn PromjeniStatus;
        private Label label1;
        private TextBox txtNazivGrada;
        private Button btnDodaj;
        private ErrorProvider err;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Label label3;
        private Button btnGenerisi;
        private CheckBox chbAktivan;
        private TextBox txtBrojGradova;
        private Label label2;
    }
}