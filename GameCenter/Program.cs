using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    
    internal class Program
    {

        
        static void Main(string[] args)
        {

            CrazyMarch crazyMarch = new CrazyMarch();



            Gamer gamer1 = new Gamer() { Id=1,Name="Füsun",Surname="Alpay",Mail="Füsun@gmail.com"};
            Gamer gamer2 = new Gamer() { Id=2,Name="Ecem",Surname="Veznedaroglu",Mail="Ecem@hotmail.com"};
            Gamer gamer3=new Gamer() { Id=3,Name="Mustafa",Surname="Veznedaroglu",Mail="Mustafa@mynet.com"};
            Gamer gamer4 = new Gamer() { Id = 4, Name = "Süleyman", Surname = "Haktan", Mail = "Haktan@gmail" };


            List<Gamer> gamers=new List<Gamer>() { gamer1,gamer2,gamer3,gamer4};
            //foreach (var Listele in gamers)
            //{
            //    Console.WriteLine(Listele.Name);
            //}

            gamer1.Log();
            Console.WriteLine("----------------------");
            foreach (var item in gamers)
            {
                Console.WriteLine(item.Name + " " + item.Id);
            }

            Company company1 = new Company() { CompanyName="Assos",CompanyNumber=1076};
            Company company2 = new Company() { CompanyName="BigBlue",CompanyNumber=14887};
            Company company3=new Company() { CompanyName="FC Barcelona",CompanyNumber=11111};

            List<Company> companies  = new List<Company>() { company1,company2,company3};
            Console.WriteLine("-----------------------");
            foreach (var item in companies)
            {
                Console.WriteLine(item.CompanyName + "  " + item.CompanyNumber);
            }


            company1.Log();

            crazyMarch.Price(gamer1, company1); 
        }
    }
}
