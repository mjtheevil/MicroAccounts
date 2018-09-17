﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroAccounts.ViewModel
{
  public  class DailyRateVM
    {
        public long rowNo { get; set; }
        public long id { get; set; }
        public Nullable<decimal> fineGold { get; set; }
        public Nullable<decimal> hallmark { get; set; }
        public Nullable<decimal> hallmarkBuyBack { get; set; }
        public Nullable<decimal> twentyTwoC { get; set; }
        public Nullable<decimal> twentyThreeC { get; set; }
        public Nullable<decimal> silver { get; set; }
        public string date { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
    }
}
