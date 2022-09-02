using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class BlackFriday : IOffer
    {
        public void Activation()
        {
            Console.WriteLine("Kara Cuma kampanyası uygulandı");
        }

        public void Price(Gamer gamer, Company company)
        {
            Console.WriteLine(gamer.Name+ " kişisi "+company.CompanyName+" şirketiyle black friday kampanyasından faydalandı");
        }
    }
}
