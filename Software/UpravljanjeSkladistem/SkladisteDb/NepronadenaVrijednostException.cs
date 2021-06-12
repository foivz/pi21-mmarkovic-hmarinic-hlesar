using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public class NepronadenaVrijednostException : Exception
    {
        public string Poruka;

        public NepronadenaVrijednostException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
