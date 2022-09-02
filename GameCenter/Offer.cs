using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public interface IOffer
    {
        void Price(Gamer gamer,Company company);
        void Activation();
        void delete();
        void Updated(Offerr offer);
        
    }
}
