namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto auto1;
        Auto auto2;
        Auto vybraneAuto;
        private void Form1_Load(object sender, EventArgs e)
        {
            auto1 = new Auto("Microsoft", Color.Azure);
            auto2 = new Auto("Škoda", Color.White);

            radioButtonCar1.Text = auto1.Znacka;
            radioButtonCar2.Text = auto2.Znacka;

            vybraneAuto = auto1;
            renderUI();
        }
        private void renderUI()
        {
            labelAuto.Text = vybraneAuto.Znacka;
            labelKm.Text = vybraneAuto.Najeto + " km";
            tankProgress.Value = (int)(((float)vybraneAuto.Nadrz / (float)vybraneAuto.maxNadrz) * 100);
        }

        private void radioButtonCar1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonCar1.Checked) { return; }
            vybraneAuto = auto1;
            renderUI();
        }

        private void radioButtonCar2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonCar2.Checked) { return; }
            vybraneAuto = auto2;
            renderUI();
        }

        private void driveBtn_Click(object sender, EventArgs e)
        {
            int ujet = (int)driveInput.Value;
            try
            {
                vybraneAuto.Jet(ujet);
            }
            catch (OutOfFuelException ex)
            {
                MessageBox.Show($"Nedostatek paliva. Chybí {ex.litersMissing} litrù.", "Nemùžeme jet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            renderUI();
        }

        private void tankBtn_Click(object sender, EventArgs e)
        {
            int natankovat = (int)tankInput.Value;
            try
            {
                vybraneAuto.Natankovat(natankovat);
            }catch(OverfillException ex)
            {
                MessageBox.Show($"Nádrž je pøíliš plná. Nevešlo by se {ex.litersOver} litrù.", "Nemùžeme tankovat tolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            renderUI();
        }
    }
    class Auto
    {
        string znacka;
        Color barva;
        int nadrz = 0;
        public readonly int maxNadrz = 200;
        int najeto = 0;
        public readonly int spotreba; // l/km
        public static readonly int cenaPaliva = 40;
        public Auto(string znacka, Color barva)
        {
            this.znacka = znacka;
            if (znacka == "Škoda")
            {
                this.spotreba = 4;
            }
            else
            {
                this.spotreba = 5;
            }
            this.barva = barva;
        }
        public int Jet(int km)
        {
            int vydej = km * spotreba;
            if (vydej > nadrz)
            {
                throw new OutOfFuelException(vydej - nadrz);
            }
            najeto += km;
            nadrz -= vydej;
            return vydej;
        }
        public int Natankovat(int l)
        {
            if (nadrz + l > maxNadrz)
            {
                throw new OverfillException(maxNadrz - nadrz + l);
            }
            nadrz += l;
            return cenaPaliva * l;
        }
        public string Znacka
        {
            get { return znacka; }
        }
        public Color Barva
        {
            get { return barva; }
        }
        public int Nadrz
        {
            get { return nadrz; }
        }
        public int Najeto
        {
            get { return najeto; }
        }

    }
    class OutOfFuelException : Exception
    {
        public int litersMissing;
        public OutOfFuelException(int litersMissing)
        {
            this.litersMissing = litersMissing;
        }
    }
    class OverfillException : Exception
    {
        public int litersOver;
        public OverfillException(int litersOver)
        {
            this.litersOver = litersOver;
        }
    }
}