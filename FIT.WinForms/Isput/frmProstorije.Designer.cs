﻿namespace FIT.WinForms.Isput
{
    partial class frmProstorije
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
            dgvProstorije = new DataGridView();
            Logo = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Oznaka = new DataGridViewTextBoxColumn();
            Kapacitet = new DataGridViewTextBoxColumn();
            BrPredmeta = new DataGridViewTextBoxColumn();
            Nastava = new DataGridViewButtonColumn();
            Prisustvo = new DataGridViewButtonColumn();
            btnNova = new Button();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).BeginInit();
            SuspendLayout();
            // 
            // dgvProstorije
            // 
            dgvProstorije.AllowUserToAddRows = false;
            dgvProstorije.AllowUserToDeleteRows = false;
            dgvProstorije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProstorije.Columns.AddRange(new DataGridViewColumn[] { Logo, Naziv, Oznaka, Kapacitet, BrPredmeta, Nastava, Prisustvo });
            dgvProstorije.Location = new Point(12, 47);
            dgvProstorije.Name = "dgvProstorije";
            dgvProstorije.ReadOnly = true;
            dgvProstorije.RowHeadersWidth = 51;
            dgvProstorije.RowTemplate.Height = 29;
            dgvProstorije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProstorije.Size = new Size(776, 356);
            dgvProstorije.TabIndex = 0;
            dgvProstorije.CellContentClick += dgvProstorije_CellContentClick;
            // 
            // Logo
            // 
            Logo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Logo.DataPropertyName = "Logo";
            Logo.HeaderText = "Logo";
            Logo.MinimumWidth = 6;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Kapacitet
            // 
            Kapacitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kapacitet.DataPropertyName = "Kapacitet";
            Kapacitet.HeaderText = "Kapacitet";
            Kapacitet.MinimumWidth = 6;
            Kapacitet.Name = "Kapacitet";
            Kapacitet.ReadOnly = true;
            // 
            // BrPredmeta
            // 
            BrPredmeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrPredmeta.DataPropertyName = "BrPredmeta";
            BrPredmeta.HeaderText = "BrPredmeta";
            BrPredmeta.MinimumWidth = 6;
            BrPredmeta.Name = "BrPredmeta";
            BrPredmeta.ReadOnly = true;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.DataPropertyName = "Nastava";
            Nastava.HeaderText = "";
            Nastava.MinimumWidth = 6;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            Nastava.Text = "Nastava";
            Nastava.UseColumnTextForButtonValue = true;
            // 
            // Prisustvo
            // 
            Prisustvo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prisustvo.DataPropertyName = "Prisustvo";
            Prisustvo.HeaderText = "";
            Prisustvo.MinimumWidth = 6;
            Prisustvo.Name = "Prisustvo";
            Prisustvo.ReadOnly = true;
            Prisustvo.Text = "Prisustvo";
            Prisustvo.UseColumnTextForButtonValue = true;
            // 
            // btnNova
            // 
            btnNova.Location = new Point(640, 12);
            btnNova.Name = "btnNova";
            btnNova.Size = new Size(148, 29);
            btnNova.TabIndex = 1;
            btnNova.Text = "Nova Prostorija";
            btnNova.UseVisualStyleBackColor = true;
            btnNova.Click += btnNova_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(694, 409);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 1;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmProstorije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNova);
            Controls.Add(dgvProstorije);
            Name = "frmProstorije";
            Text = "frmProstorije";
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProstorije;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Kapacitet;
        private DataGridViewTextBoxColumn BrPredmeta;
        private DataGridViewButtonColumn Nastava;
        private DataGridViewButtonColumn Prisustvo;
        private Button btnNova;
        private Button btnPrintaj;
    }
}