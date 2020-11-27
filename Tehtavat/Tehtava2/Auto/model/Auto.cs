using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Autokauppa.model
{
    public class Auto
    {
        private string nimi;
        private int tietotupi;
        private Decimal hinta;
        private DateTime Rekisteri_paivamaara;
        private Decimal moottorin_tilavuus;
        private int mittarilukema;
        private int autonMerkkiID;
        private int autonMalliID;
        private int varitID;
        private int polttoaineID;
        public int Tietotupi { get => tietotupi; set => tietotupi = value; }
        public string Nimi { get => nimi; set => nimi = value; }
        public Decimal Hinta { get => hinta; set => hinta = value; }
        public DateTime rekisteri_paivamaara { get => Rekisteri_paivamaara; set => Rekisteri_paivamaara = value; }
        public Decimal Moottorin_tilavuus { get => moottorin_tilavuus; set => moottorin_tilavuus = value; }
        public int Mittarilukema { get => mittarilukema; set => mittarilukema = value; }
        public int AutonMerkkiID { get => autonMerkkiID; set => autonMerkkiID = value; }
        public int AutonMalliID { get => autonMalliID; set => autonMalliID = value; }
        public int VariID { get => varitID; set => varitID = value; }
        public int PolttoaineID { get => polttoaineID; set => polttoaineID = value; }

    }
}
