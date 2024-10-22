namespace FIT.WinForms.IB220024WinForms
{
    partial class frmDrzaveIB220024
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
            dgvDrzave = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Drzava = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            timer = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            btnPrint = new Button();
            btnNovaDrzava = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            SuspendLayout();
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.AllowUserToOrderColumns = true;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Drzava, BrojGradova, Aktivna, Gradovi });
            dgvDrzave.Location = new Point(12, 89);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.RowTemplate.Height = 25;
            dgvDrzave.Size = new Size(776, 281);
            dgvDrzave.TabIndex = 0;
            dgvDrzave.CellContentClick += dgvDrzave_CellContentClick;
            dgvDrzave.CellDoubleClick += dgvDrzave_CellDoubleClick;
            // 
            // Zastava
            // 
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // BrojGradova
            // 
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj Gradova";
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            Aktivna.Resizable = DataGridViewTriState.True;
            Aktivna.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Gradovi
            // 
            Gradovi.HeaderText = "";
            Gradovi.Name = "Gradovi";
            Gradovi.Text = "Gradovi";
            Gradovi.UseColumnTextForButtonValue = true;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(12, 426);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(144, 15);
            lblTimer.TabIndex = 1;
            lblTimer.Text = "Trenutno vrijeme: 00:00:00";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(693, 376);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(95, 23);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Printaj";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(693, 60);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(95, 23);
            btnNovaDrzava.TabIndex = 3;
            btnNovaDrzava.Text = "Nova drzava";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // frmDrzaveIB220024
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNovaDrzava);
            Controls.Add(btnPrint);
            Controls.Add(lblTimer);
            Controls.Add(dgvDrzave);
            Name = "frmDrzaveIB220024";
            Text = "Drzave";
            Load += frmDrzaveIB220024_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDrzave;
        private System.Windows.Forms.Timer timer;
        private Label lblTimer;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewButtonColumn Gradovi;
        private Button btnPrint;
        private Button btnNovaDrzava;
    }
}