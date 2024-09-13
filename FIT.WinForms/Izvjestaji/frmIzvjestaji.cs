using FIT.Data.Ispit;
using FIT.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Prostorije kliknutaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(Prostorije kliknutaProstorija)
        {
            InitializeComponent();
            this.kliknutaProstorija = kliknutaProstorija;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var prostorija = kliknutaProstorija.Naziv;

            var podaciPrisustvo = db.Prisustvo.Where(x=>x.NastavaId==db.Nastava.FirstOrDefault(x=>x.ProstorijaId==kliknutaProstorija.Id).Id).ToList();

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("prostorija", prostorija));
            rpc.Add(new ReportParameter("brojStudenata",podaciPrisustvo.Count().ToString()));

            //MessageBox.Show($"{podaciPrisustvo.Count()}");

            var dt = new DataSet1.DataTable1DataTable();

            for (int i = 0; i < podaciPrisustvo.Count(); i++)
            {
                var red = dt.NewDataTable1Row();
                var nastava = db.Nastava.FirstOrDefault(x => x.Id == podaciPrisustvo[i].NastavaId);
                var predmet = db.Predmeti.FirstOrDefault(x => x.Id == nastava.PredmetId);
                var student = db.Studenti.FirstOrDefault(x => x.Id == podaciPrisustvo[i].StudentId);

                red.Rb = $"{i+1}".ToString();
                red.Predmet = predmet.Naziv;
                red.Vrijeme = nastava.Vrijeme;
                red.BrojIndeksa = student.Indeks;
                red.ImePrezime = $"{student.Ime} {student.Prezime}";

                dt.Rows.Add(red);
            }
            var rds = new ReportDataSource()
            {
                Name = "DataSet1",
                Value = dt
            };

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
