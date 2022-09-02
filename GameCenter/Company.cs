using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class Company : Register, IVerify
    {
        public void Log()
        {
            Console.WriteLine("Şirketiniz başarıyla oluşturuldu");
        }
    }
}
