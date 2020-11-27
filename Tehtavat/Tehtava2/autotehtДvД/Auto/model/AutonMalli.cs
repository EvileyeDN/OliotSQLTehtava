using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.controller;
namespace Autokauppa.model
{
    public class AutonMalli
    {
        private int id;
        private int MerkkiID;
        private string Mallinimi;
        public int ID { get => id; set => id = value; }
        public string MalliNimi { get => Mallinimi; set => Mallinimi = value; }
        public int MerkkiId { get => MerkkiID; set => MerkkiID = value; }
    }
}
