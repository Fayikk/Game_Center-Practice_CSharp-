using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class CrazyMarch : IOffer
    {
        public void Activation()
        {
            Console.WriteLine("Crazy march kampanyası uygulandı");
        }

        public void Price(Gamer gamer, Company company)
        {
            Console.WriteLine(gamer.Name + " kişisi " + company.CompanyName + " şirketiyle crazy march kampanyasından faydalandı");

        }
    }
}
