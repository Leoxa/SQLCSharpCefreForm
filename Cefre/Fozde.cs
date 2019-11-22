using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cefre
{
    class Fozde
    {
        int id;
        string nev;
        string tulajdonos;
        DateTime alapitva;

        public Fozde(int id, string nev, string tulajdonos, DateTime alapitva)
        {
            this.id = id;
            this.nev = nev;
            this.tulajdonos = tulajdonos;
            this.alapitva = alapitva;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Tulajdonos { get => tulajdonos; set => tulajdonos = value; }
        public DateTime Alapitva { get => alapitva; set => alapitva = value; }
    }
}
