using FIT.Data;
using FIT.Data.Ispit;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Isput
{
    public partial class frmNovaProstorija : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaProstorija()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var prostorija = new Prostorije()
                {
                    Logo = Helpers.Ekstenzije.ToByteArray(pbLogo.Image),
                    Naziv=txtNaziv.Text,
                    Oznaka=txtOznaka.Text,
                    Kapacitet = int.Parse(txtKapacitet.Text)
                };
                db.Prostorije.Add(prostorija);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(pbLogo, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtKapacitet, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtOznaka, err, Kljucevi.ReqiredValue);
        }
    }
}
