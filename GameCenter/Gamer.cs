using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class Gamer : Register, IVerify
    {
        public void Log()
        {
            Console.WriteLine("Başarıyla giriş yapıldı(E devlet kontolü ile)");
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
