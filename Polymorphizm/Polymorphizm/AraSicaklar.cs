using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
    class AraSicaklar:Yemek
    {
        public override string SunumSekli()
        {
            return "Yaninda patates ve salata verin!";
        }
    }
}
