
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        
        string yhteysTiedot;
        SqlConnection dbYhteys = new SqlConnection();
       public int ConnectButton = 0;
        public DatabaseHallinta()
        {
            yhteysTiedot = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewAuto1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
        }

        public bool connectDatabase()
        {
            

            try
            {
                dbYhteys.ConnectionString = yhteysTiedot;
                dbYhteys.Open();
                if (ConnectButton == 1)
                {
                    MessageBox.Show("Connection established");
                    ConnectButton = 0;
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                MessageBox.Show("connection lost");
                return false;

            }



        }
        public int GetVariID(int AutoID)
        {
            SqlDataReader myReader = null;
            int VariID = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (VaritID) FROM [Auto] WHERE (AutonMalliID = '" + AutoID + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        VariID = Convert.ToInt32(myReader["VaritID"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return VariID;
        }
        public string GetVari(int VariD)
        {
            SqlDataReader myReader = null;
            string Vari = "0";
            try
            {
                SqlCommand command = new SqlCommand("SELECT (Varin_nimi) FROM [Varit] WHERE (ID = '" + VariD + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        Vari = myReader["Varin_nimi"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return Vari;
        }
        public int GetPolttoaineID(int AutoID)
        {
            SqlDataReader myReader = null;
            int PoltoaineID = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (PolttoaineID) FROM [Auto] WHERE (AutonMalliID = '" + AutoID + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        PoltoaineID = Convert.ToInt32(myReader["PolttoaineID"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return PoltoaineID;
        }
        public string GetPolttoaine(int PolttoaineID)
        {
            SqlDataReader myReader = null;
            string Polttoaine = "0";
            try
            {
                SqlCommand command = new SqlCommand("SELECT (Polttoaineen_nimi) FROM [Polttoaine] WHERE (ID = '" + PolttoaineID + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        Polttoaine = myReader["Polttoaineen_nimi"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return Polttoaine;
        }
        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            bool palaute = false;
            return palaute;


        }

        public List<AutonMerkki> getAllAutoMakersFromDatabase()
        {
            SqlDataReader myReader = null;
            List<AutonMerkki> autonMerkki= new List<AutonMerkki>();
            SqlCommand command = new SqlCommand("SELECT * FROM [AutonMerkki]", dbYhteys);
            try
            {
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        AutonMerkki autonmerkki = new AutonMerkki();
                        autonmerkki.ID = Convert.ToInt32(myReader["ID"]);
                        autonmerkki.MerkkiNimi = myReader["Merkki"].ToString();
                        autonMerkki.Add(autonmerkki);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }


            return autonMerkki;

        }
        public int MerkkiBoxLisata(string AutoMalli)
        {
            SqlDataReader myReader = null;
            int AutoID = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (ID) FROM [AutonMallit] WHERE (Auton_mallin_nimi = '"+ AutoMalli +"')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        AutoID = Convert.ToInt32(myReader["ID"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
            return AutoID;
            
        }
        public int GetAutoTaulunID(int AutoMalliID)
        {
            SqlDataReader myReader = null;
            int AutoID = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (ID) FROM [Auto] WHERE (AutonMalliID = '" + AutoMalliID + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        AutoID = Convert.ToInt32(myReader["ID"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            return AutoID;
        }
        public decimal GetHinta(int AutoID)
        {
            decimal Hinta = 999999;
            SqlDataReader myReader = null;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (Hinta) FROM [Auto] WHERE (AutonMalliID = '" + AutoID + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        Hinta = Convert.ToDecimal(myReader["Hinta"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Hinta;
        }
        public int GetMiitariLukema(int AutoID)
        {
            int Mitari = 999999;
            SqlDataReader myReader = null;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (Mittarilukema) FROM [Auto] WHERE (AutonMalliID = '" + AutoID + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        Mitari = Convert.ToInt32(myReader["Mittarilukema"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Mitari;
        }
        public int GetAutoMalliID(int AutoTaulunID)
        {
            int AutoMalliID = 1;
            SqlDataReader myReader = null;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (AutonMalliID) FROM [Auto] WHERE (ID = '" + AutoTaulunID + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        AutoMalliID = Convert.ToInt32(myReader["AutonMalliID"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return AutoMalliID;
        }
        public string GetAutoMalli(int AutoMalliID)
        {
            SqlDataReader myReader = null;
            string AutoMalli = "";
            try
            {
                SqlCommand command = new SqlCommand("SELECT (Auton_mallin_nimi) FROM [AutonMallit] WHERE (ID = '" + AutoMalliID + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        AutoMalli = myReader["Auton_mallin_nimi"].ToString();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return AutoMalli;
        }
        public decimal GetMotorinTilavuus(int AutoID)
        {
            decimal Motori = 999999;
            SqlDataReader myReader = null;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (Moottorin_tilavuus) FROM [Auto] WHERE (AutonMalliID = '" + AutoID + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        Motori = Convert.ToDecimal(myReader["Moottorin_tilavuus"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Motori;
        }
       

        public List<AutonMalli> getAutoModelsByMakerId(int makerId) 
             
        {
            SqlDataReader myReader = null;
            List<AutonMalli> autonmalli = new List<AutonMalli>();
           
            try 
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [AutonMallit] WHERE (AutonMerkkiID = '" + makerId + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        AutonMalli autonmallit = new AutonMalli();
                        autonmallit.ID = Convert.ToInt32(myReader["ID"]);
                        autonmallit.MerkkiId = Convert.ToInt32(myReader["AutonMerkkiID"]);
                        autonmallit.MalliNimi = myReader["Auton_mallin_nimi"].ToString();
                        autonmalli.Add(autonmallit);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return autonmalli;
        }
        public void getNewAuto(string MalliNimi,decimal Hinta,string RekisteriDate,double MotorinTilavuus,int Mittarilukema,int AutonMerkkiID,int VariID,int PolltoaineID, int MAXid)
        {
            try
            {
                SqlCommand command = new SqlCommand("SET IDENTITY_INSERT [AutonMallit] ON INSERT INTO [AutonMallit] (ID,Auton_mallin_nimi,AutonMerkkiID) VALUES('" + MAXid + "'," + "'" + MalliNimi + "'," + "'" + AutonMerkkiID + "'); SET IDENTITY_INSERT [AutonMallit] OFF " + " INSERT INTO [auto] (Hinta,Rekisteri_paivamaara,Moottorin_tilavuus,Mittarilukema,AutonMerkkiID,AutonMalliID,VaritID,PolttoaineID) VALUES('" + Hinta + "','" + RekisteriDate + "','" + MotorinTilavuus + "','" + Mittarilukema + "','" + AutonMerkkiID + "','" + MAXid + "','" + VariID + "','" + PolltoaineID + "');", dbYhteys);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
        public int GetVariIDVer2(string Vari)
        {
            SqlDataReader myReader = null;
            int VariID=0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (ID) FROM [Varit] WHERE (Varin_nimi = '" + Vari + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        VariID = Convert.ToInt32(myReader["ID"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return VariID;
        }
        public int GetPolttoaineVer2(string Polttoaine)
        {
            SqlDataReader myReader = null;
            int PolttoaineID = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT (ID) FROM [Polttoaine] WHERE (Polttoaineen_nimi = '" + Polttoaine + "')", dbYhteys);
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        PolttoaineID = Convert.ToInt32(myReader["ID"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return PolttoaineID;
        }
        public int GetMaxAutoMalli()
        {
            int MAX=1;
            SqlCommand command = new SqlCommand("SELECT MAX(AutonMalliID) FROM [auto]", dbYhteys);
            MAX = Convert.ToInt32(command.ExecuteScalar());
            MAX++;
            return MAX;
        }

    }
}
