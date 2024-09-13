using FIT.Data.Ispit;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmProstorije : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Prostorije> podaciProstorije = new List<Prostorije>();
        public frmProstorije()
        {
            InitializeComponent();
            UcitajProstorije();
        }

        private void UcitajProstorije()
        {
            podaciProstorije = db.Prostorije.ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Logo", typeof(Image));
            dt.Columns.Add("Naziv");
            dt.Columns.Add("Oznaka");
            dt.Columns.Add("Kapacitet");
            dt.Columns.Add("BrPredmeta");

            for (int i = 0; i < podaciProstorije.Count; i++)
            {
                var red = dt.NewRow();
                var podatakProstorija = podaciProstorije[i];
                var listaPredmeta = db.Nastava.Where(x => x.ProstorijaId == podatakProstorija.Id).ToList();

                red["Logo"] = Helpers.Ekstenzije.ToImage(podatakProstorija.Logo);
                red["Naziv"] = podatakProstorija.Naziv;
                red["Oznaka"] = podatakProstorija.Oznaka;
                red["Kapacitet"] = podatakProstorija.Kapacitet.ToString();
                red["BrPredmeta"] = listaPredmeta.Count().ToString();

                dt.Rows.Add(red);
            }
            dgvProstorije.DataSource = dt;
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            //new frmNovaProstorija().Show();
            var forma = new frmNovaProstorija();
            if (DialogResult.OK == forma.ShowDialog())
            {
                UcitajProstorije();
            }
        }

        private void dgvProstorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProstorije.Columns[e.ColumnIndex].Name == "Nastava")
            {
                var kliknutaProstoija = podaciProstorije[e.RowIndex];
                //new frmNastava(kliknutaProstoija).Show();
                var forma = new frmNastava(kliknutaProstoija);
                if (DialogResult.OK == forma.ShowDialog())
                {
                    UcitajProstorije();
                }
            }
            else if (dgvProstorije.Columns[e.ColumnIndex].Name == "Prisustvo")
            {
                var kliknutaProstoija = podaciProstorije[e.RowIndex];
                var brojNastave = db.Nastava.Count(x => x.ProstorijaId == kliknutaProstoija.Id);
                if (brojNastave > 0)
                {
                    var forma = new frmPrisustvo(kliknutaProstoija);
                    if (DialogResult.OK == forma.ShowDialog())
                    {
                        UcitajProstorije();
                    }
                }
                else
                {
                    MessageBox.Show("U ovoj prostoriji nema nastave, molimo da prvo dodate nastavu, lp");
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            if(dgvProstorije.SelectedRows.Count > 0)
            {
                var red = dgvProstorije.SelectedRows[0].Cells["Naziv"].Value.ToString();
                var kliknutaProstorija = db.Prostorije.FirstOrDefault(x => x.Naziv == red);
                if(kliknutaProstorija!= null)
                {
                    var report = new frmIzvjestaji(kliknutaProstorija);
                    report.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Molimo odaberite prostoriju!");
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite prostoriju!");
            }
        }
    }
}
