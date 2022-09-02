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

        public void delete()
        {
            Console.WriteLine("Crazy march kampanyası silinmiştir");

        }

        public void Price(Gamer gamer, Company company)
        {
            Console.WriteLine(gamer.Name + " kişisi " + company.CompanyName + " şirketiyle crazy march kampanyasından faydalandı");

        }

        public void Updated()
        {
            Console.WriteLine("Crazy March kampanyası güncellendi");
        }

        public void Updated(Offerr offer)
        {
            throw new NotImplementedException();
        }
    }
}
