using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawnshop.Models
{
    public class PawnshopList
    {
        public bool IsDirty { set; get; }

        public List<Lot> Lots { set; get; }

        public PawnshopList()
        {
            IsDirty = false;
            Lots = new List<Lot>();
        }
    }
}
