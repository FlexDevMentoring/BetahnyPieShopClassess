using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetahnyPieShopClassess.HumanResources
{
    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {

        }
    }
}
