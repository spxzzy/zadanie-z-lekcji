using WinFormsApp1.modeldanych;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Pobieracz pobieracz;
        public Form1()
        {
            InitializeComponent();
            pobieracz = new Pobieracz();
            pobieracz.PobierzDane();
            PokazDane();
        }
        public void PokazDane()
        {
            textboxOsoby.Clear();
            foreach(Osoba osoba in pobieracz.listaOsob)
            {
                textboxOsoby.Text += osoba.ToString();
            }
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            pobieracz.listaOsob.Sort();
            PokazDane();
        }
    }
}