using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBillSystem
{
    class CommercialBill:ElectricBill
    {
        private
            int units;

        public CommercialBill(int units)
        {
            this.units = units;
        }
        override
        public int Bill_Amount()
        {
            int BillAmount = 0;
            if (units <= 100)
            {
                BillAmount = units * 8;
            }
            else if (units > 100 && units <= 200)
            {
                BillAmount = units * 21;
            }
            else if (units > 200 && units <= 500)
            {
                BillAmount = units * 23;
            }
            else if (units > 500)
            {
                BillAmount = units * 79;
            }
            return BillAmount;
        }
        override
        public double show_bill()
        {
            int net_bill_amount = Bill_Amount();
            return net_bill_amount + net_bill_amount * 0.17;
        }
    }
}
