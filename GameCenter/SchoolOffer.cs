﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class SchoolOffer : IOffer
    {
        public void Activation()
        {
            Console.WriteLine("Okul kampanyası uygulandı");
        }

        public void delete()
        {
            Console.WriteLine("Okul kampanyası silinmiştir");
        }

        public void Price(Gamer gamer, Company company)
        {
            Console.WriteLine(gamer.Name + " kişisi " + company.CompanyName + " şirketiyle school offer kampanyasından faydalandı");

        }

        public void Updated()
        {
            Console.WriteLine("Okul kampanyası güncellenmiştir");
        }

        public void Updated(Offerr offer)
        {
            throw new NotImplementedException();
        }
    }
}
