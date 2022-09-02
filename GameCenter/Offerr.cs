using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class Offerr :Company,IOffer
    {
        public void Activation()
        {
            
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void Price(Gamer gamer, Company company)
        {
            throw new NotImplementedException();
        }

        
        public void Updated(Offerr offer)
        {
            var lastPrice=0;
            lastPrice = offer.ProductPrice - (offer.ProductPrice * 30) / 100;
           

            Console.WriteLine("oyunun fiyatı -> "+ offer.ProductPrice);
            Console.WriteLine(offer.OfferName+" kampanyası ile "+offer.ProductName+" oyunun'un indirimli fiyatı -> " +lastPrice);

            
        }
    }
}
