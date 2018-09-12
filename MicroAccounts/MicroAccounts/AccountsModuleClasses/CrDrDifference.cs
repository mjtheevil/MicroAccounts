using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroAccounts.Data;

namespace MicroAccounts.AccountsModuleClasses
{
    public class CrDrDifference
    {
        MicroAccountsEntities1 _entities;
        public string DifferenceCrDr(long ledgerId, int passedVoucherType)
        {
            _entities = new MicroAccountsEntities1();
            decimal? drTotal = 0, crTotal = 0, crdrDiff = 0;

            _entities = new MicroAccountsEntities1();

            var data = _entities.tbl_TransactionMaster.Where(x => x.ledgerId == ledgerId).ToList();

            foreach (var item in data)
            {
                drTotal += item.drAmt;
                crTotal += item.crAmt;
            }

          //  if (passedVoucherType == 1)   //For Payment
                crdrDiff = drTotal - crTotal;

           // else if (passedVoucherType == 2) // For Receipt
            //    crdrDiff = crTotal - drTotal;


            if (crdrDiff < 0)
            {
                string cr = crdrDiff.ToString();

                return ("Cr " + cr.Substring(1));
            }
            else if (crdrDiff > 0)
                return ("Dr " + crdrDiff);
            else
                return ("0.00");
        }
    }
}

