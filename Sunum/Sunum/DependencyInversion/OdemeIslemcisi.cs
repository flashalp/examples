using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunum.DependencyInversion
{
    public class OdemeIslemcisi
    {
        private IOdeme odemeyontemi;
        public OdemeIslemcisi(IOdeme odemeyontemi)
        {
            this.odemeyontemi = odemeyontemi;
        }
        public void OdemeYap()
        {
            odemeyontemi.Odeme();
        }
    }
}
