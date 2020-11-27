using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.controller;

namespace Autokauppa.model
{
    public class AutonMerkki
    {

        private int id;
        private string merkkiNimi;
        public int ID { get => id; set => id = value; }
        public string MerkkiNimi { get => merkkiNimi; set => merkkiNimi = value; }
    }
}
