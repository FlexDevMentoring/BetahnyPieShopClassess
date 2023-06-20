using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetahnyPieShopClassess.HumanResources
{
    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
        {

        }
    }
}
