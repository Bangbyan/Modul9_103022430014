using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022430014
{
    internal class Transfer
    {
        public double thresold
        {
            get; set;
        }
        public double low_fee
        {
            get; set;
        }
        public double high_fee
        {
            get; set;
        }
        public Transfer()
        {

        }
        public Transfer(double thresold, double low_fee, double high_fee)
        {
            this.thresold = thresold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }
}
