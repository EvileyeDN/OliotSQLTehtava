using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.controller;
using Autokauppa.model;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {

        KaupanLogiikka registerHandler;
        int autoID;
        int SeuravaAndEdelinen=0;
        int AutoID=0;


        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerHandler.TestDatabaseConnection();
        }

        private void test_Click(object sender, EventArgs e)
        {
            string Year, Month, day,RekisteriPaiva;
            day=this.Rekisteröintipäivämäärä.Value.Day.ToString();
            Month = this.Rekisteröintipäivämäärä.Value.Month.ToString();
            Year = this.Rekisteröintipäivämäärä.Value.Year.ToString();
            RekisteriPaiva = Year + "-" + Month + "-" + day;
        }

        private void Merkki_Click(object sender, EventArgs e)
        {
            //registerHandler.getAllAutoMakers();
            this.MerkkiBox.Items.Clear();
            foreach (var List in registerHandler.getAllAutoMakers())
            {
                this.MerkkiBox.Items.Add(List.MerkkiNimi);
                
            }
            registerHandler.Disconect();

            

        }
        public void Clear()
        {
            this.hinta.Text = "";
            this.mittarilukema.Text = "";
            this.moottorintilavuus.Text = "";
            this.VariBox.Text = "";
            this.PolltoaieBox.Text = "";
            SeuravaAndEdelinen = 0;
            this.MerkkiANDmaali.Items.Clear();
            this.MerkkiANDmaali.Text = "";
        }

        private void MerkkiBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            this.Uusi.Enabled = true;
            
            autoID = this.MerkkiBox.SelectedIndex+1;
            foreach (var List in registerHandler.getAutoModels(autoID))
            {
                this.MerkkiANDmaali.Items.Add(List.MalliNimi);
            }
            registerHandler.Disconect();
            
        }

        private void MerkkiANDmaali_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Seurava.Enabled = true;
            this.EdellinenButton.Enabled = true;
            string Malli = this.MerkkiANDmaali.Text;
           // registerHandler.getAutoID(Malli);
           // MessageBox.Show(registerHandler.getAutoID(Malli).ToString());
            this.hinta.Text = registerHandler.getHinta(registerHandler.getAutoID(Malli)).ToString();
            registerHandler.Disconect();
            this.mittarilukema.Text = registerHandler.getMittari(registerHandler.getAutoID(Malli)).ToString();
            registerHandler.Disconect();
            this.moottorintilavuus.Text = registerHandler.getMottorinTiilavus(registerHandler.getAutoID(Malli)).ToString();
            registerHandler.Disconect();
            this.VariBox.Text = registerHandler.GetVari(registerHandler.getVariID(registerHandler.getAutoID(Malli)));
            registerHandler.Disconect();
            this.PolltoaieBox.Text = registerHandler.GetPolttoaine(registerHandler.GetPolttoaineID(registerHandler.getAutoID(Malli)));
            registerHandler.Disconect();
            SeuravaAndEdelinen = 0;

        }

        private void Poista_Click(object sender, EventArgs e)
        {

        }

        private void Uusi_Click(object sender, EventArgs e)
        {
            Clear();
            this.Seurava.Enabled = false;
            this.Talenna.Enabled = true;
            this.EdellinenButton.Enabled = false;
        }

        private void Seurava_Click(object sender, EventArgs e)
        {


            string Malli = this.MerkkiANDmaali.Text;
            if (SeuravaAndEdelinen == 0)
            {
                
                SeuravaAndEdelinen = 1;
                AutoID = registerHandler.GetAutoTaulunID(registerHandler.getAutoID(Malli));
                registerHandler.Disconect();

            }
            AutoID++;
            
            this.MerkkiANDmaali.Text = registerHandler.GetAutoMalli(registerHandler.GetAutoMalliID(AutoID));
            registerHandler.Disconect();
            Malli = this.MerkkiANDmaali.Text;
            this.hinta.Text = registerHandler.getHinta(registerHandler.getAutoID(Malli)).ToString();
            registerHandler.Disconect();
            this.mittarilukema.Text = registerHandler.getMittari(registerHandler.getAutoID(Malli)).ToString();
            registerHandler.Disconect();
            this.moottorintilavuus.Text = registerHandler.getMottorinTiilavus(registerHandler.getAutoID(Malli)).ToString();
            registerHandler.Disconect();
            this.VariBox.Text = registerHandler.GetVari(registerHandler.getVariID(registerHandler.getAutoID(Malli)));
            registerHandler.Disconect();
            this.PolltoaieBox.Text = registerHandler.GetPolttoaine(registerHandler.GetPolttoaineID(registerHandler.getAutoID(Malli)));
            registerHandler.Disconect();

        }

        private void EdellinenButton_Click(object sender, EventArgs e)
        {
            string Malli = this.MerkkiANDmaali.Text;
            if (SeuravaAndEdelinen == 0)
            {
                
                SeuravaAndEdelinen = 1;
                AutoID = registerHandler.GetAutoTaulunID(registerHandler.getAutoID(Malli));
                registerHandler.Disconect();

            }
            AutoID--;

            this.MerkkiANDmaali.Text = registerHandler.GetAutoMalli(registerHandler.GetAutoMalliID(AutoID));
            registerHandler.Disconect();
            Malli = this.MerkkiANDmaali.Text;
            this.MerkkiANDmaali.Text = registerHandler.GetAutoMalli(registerHandler.GetAutoMalliID(AutoID));
            registerHandler.Disconect();
            this.hinta.Text = registerHandler.getHinta(registerHandler.getAutoID(Malli)).ToString();
            registerHandler.Disconect();
            this.mittarilukema.Text = registerHandler.getMittari(registerHandler.getAutoID(Malli)).ToString();
            registerHandler.Disconect();
            this.moottorintilavuus.Text = registerHandler.getMottorinTiilavus(registerHandler.getAutoID(Malli)).ToString();
            registerHandler.Disconect();
            this.VariBox.Text = registerHandler.GetVari(registerHandler.getVariID(registerHandler.getAutoID(Malli)));
            registerHandler.Disconect();
            this.PolltoaieBox.Text = registerHandler.GetPolttoaine(registerHandler.GetPolttoaineID(registerHandler.getAutoID(Malli)));
            registerHandler.Disconect();
        }

        private void Talenna_Click(object sender, EventArgs e)
        {
            
            int MAXID = 0;
            MAXID = registerHandler.GetMaxAutoMalli();
            registerHandler.Disconect();
            string Malli = "0";
            Malli = this.MerkkiANDmaali.Text;
            decimal Hinta = 0;
            Hinta = Convert.ToInt32(this.hinta.Text);
            float MottorinTilavuus = 0;
            MottorinTilavuus = Convert.ToInt32(this.moottorintilavuus.Text);
            string Year, Month, day, RekisteriPaiva;
            day = this.Rekisteröintipäivämäärä.Value.Day.ToString();
            Month = this.Rekisteröintipäivämäärä.Value.Month.ToString();
            Year = this.Rekisteröintipäivämäärä.Value.Year.ToString();
            RekisteriPaiva = Year + "-" + Month + "-" + day;
            int Mittarilukema = 0;
            Mittarilukema = Convert.ToInt32(this.mittarilukema.Text);
            int MalliID;
            MalliID = registerHandler.GetMaxAutoMalli();
            registerHandler.Disconect();
            int VariID = 0;
            VariID = registerHandler.GetVariIDVer2(this.VariBox.Text);
            registerHandler.Disconect();
            int PolltoaineID = 0;
            PolltoaineID = registerHandler.GetPolttoaineIDver2(this.PolltoaieBox.Text);
            registerHandler.Disconect();
            registerHandler.GetNewAuto(Malli, Hinta, RekisteriPaiva, MottorinTilavuus, Mittarilukema, autoID, VariID, PolltoaineID, MAXID);
            registerHandler.Disconect();

        }
    }
}
