using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBillSystem
{
   abstract class ElectricBill
    {
        abstract public int Bill_Amount();
        abstract public double show_bill();
        }
    }
