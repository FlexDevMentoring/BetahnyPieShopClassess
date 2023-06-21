using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetahnyPieShopClassess.HumanResources
{
    public interface IEmployee : IComparable

    {
        double ReceiveWage();
        void GiveBonus();
        void PerformWork();
        void StopWorking();
        void DisplayEmployeeDetails();
        void GiveCompliment();

    }
}
