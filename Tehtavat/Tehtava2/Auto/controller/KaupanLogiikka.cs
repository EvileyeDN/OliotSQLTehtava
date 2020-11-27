using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Autokauppa;
using Autokauppa.model;


namespace Autokauppa.controller
{

    
    public class KaupanLogiikka
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();
        public void TestDatabaseConnection()
        {
            dbModel.ConnectButton = 1;
            dbModel.connectDatabase();
            dbModel.disconnectDatabase();
            
            

        }
        public void Disconect()
        {
            dbModel.disconnectDatabase();
        }

        public bool saveAuto(Auto newAuto) 
        {
            bool didItGoIntoDatabase = dbModel.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<AutonMerkki> getAllAutoMakers() 
        {
            dbModel.connectDatabase();
            dbModel.getAllAutoMakersFromDatabase();

            return dbModel.getAllAutoMakersFromDatabase();
            
        }

        public List<AutonMalli> getAutoModels(int makerId) 
        {
            dbModel.connectDatabase();
            dbModel.getAutoModelsByMakerId(makerId);

            return dbModel.getAutoModelsByMakerId(makerId);
        }
        public int getAutoID(string AutoMalli)
        {
            dbModel.connectDatabase();
            dbModel.MerkkiBoxLisata(AutoMalli);
            return dbModel.MerkkiBoxLisata(AutoMalli);
            
        }
        public decimal getHinta(int AutoID)
        {
            
           // dbModel.GetHinta(AutoID);
            return dbModel.GetHinta(AutoID);
        }
        public int getMittari(int AutoID)
        {

           // dbModel.GetMiitariLukema(AutoID);
            return dbModel.GetMiitariLukema(AutoID);
        }
        public decimal getMottorinTiilavus(int AutoID)
        {

            //dbModel.GetMotorinTilavuus(AutoID);
            return dbModel.GetMotorinTilavuus(AutoID);
        }
        public int getVariID(int AutoID)
        {
            return dbModel.GetVariID(AutoID);
        }
        public string GetVari(int VariID)
        {
            return dbModel.GetVari(VariID);
        }
        public int GetPolttoaineID(int AutoID)
        {
            return dbModel.GetPolttoaineID(AutoID);
        }
        public string GetPolttoaine(int PolttoaineID)
        {
            return dbModel.GetPolttoaine(PolttoaineID);
        }
        public int GetAutoTaulunID(int AutoMalliID)
        {
            return dbModel.GetAutoTaulunID(AutoMalliID);
        }
        public int GetAutoMalliID(int AutoTaulunID)
        {
            dbModel.connectDatabase();
            return dbModel.GetAutoMalliID(AutoTaulunID);
        }
        public string GetAutoMalli(int AutoMalliID)
        {
            return dbModel.GetAutoMalli(AutoMalliID);
        }
        public int GetVariIDVer2(string Vari)
        {
            dbModel.connectDatabase();
            return dbModel.GetVariIDVer2(Vari);
        }
        public int GetPolttoaineIDver2(string Polttoaine)
        {
            dbModel.connectDatabase();
            return dbModel.GetPolttoaineVer2(Polttoaine);
        }
        public int GetMaxAutoMalli()
        {
            dbModel.connectDatabase();
            return dbModel.GetMaxAutoMalli();
        }
        public void GetNewAuto(string MalliNimi, decimal Hinta, string RekisteriDate, double MotorinTilavuus, int Mittarilukema, int AutonMerkkiID, int VariID, int PolltoaineID, int MAXid)
        {
            dbModel.connectDatabase();
            dbModel.getNewAuto(MalliNimi,Hinta, RekisteriDate, MotorinTilavuus, Mittarilukema, AutonMerkkiID, VariID, PolltoaineID, MAXid);
        }



    }
}
