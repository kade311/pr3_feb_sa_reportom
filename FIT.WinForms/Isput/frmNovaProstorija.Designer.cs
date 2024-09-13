namespace FIT.WinForms.Isput
{
    partial class frmNovaProstorija
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
            pbLogo = new PictureBox();
            label1 = new Label();
            txtNaziv = new TextBox();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            label2 = new Label();
            txtOznaka = new TextBox();
            txtKapacitet = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(12, 32);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(343, 272);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pictureBox1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "Logo";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(361, 32);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(296, 27);
            txtNaziv.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(563, 275);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Oznaka";
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(361, 94);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(125, 27);
            txtOznaka.TabIndex = 2;
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(532, 94);
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(125, 27);
            txtKapacitet.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 9);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 1;
            label3.Text = "Naziv";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 71);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "Kapacitet";
            // 
            // frmNovaProstorija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 316);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtKapacitet);
            Controls.Add(txtOznaka);
            Controls.Add(txtNaziv);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            Name = "frmNovaProstorija";
            Text = "frmNovaProstorija";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label label1;
        private TextBox txtNaziv;
        private Button btnSacuvaj;
        private ErrorProvider err;
        private TextBox txtKapacitet;
        private TextBox txtOznaka;
        private Label label4;
        private Label label3;
        private Label label2;
        private OpenFileDialog openFileDialog1;
    }
}