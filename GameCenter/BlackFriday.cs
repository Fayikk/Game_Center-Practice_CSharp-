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

        public void Activation(Offerr offerr)
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            Console.WriteLine("Black friday kampanyası silinmiştir");
        }

        public void Price(Gamer gamer, Company company)
        {
            Console.WriteLine(gamer.Name+ " kişisi "+company.CompanyName+" şirketiyle black friday kampanyasından faydalandı");
        }

        public void Updated()
        {
            Console.WriteLine("Black friday kampanyası güncellenmiştir");
        }

        public void Updated(Offerr offer)
        {
            throw new NotImplementedException();
        }
    }
}
