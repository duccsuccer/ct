using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileplan
{
    internal class MobilePlan
    {
        public string Number { get; set; }
        public int Data { get; set; }
        MobilePlan() { }
        public MobilePlan(string number, int data)
        {
            Number = number;
            Data = data;
        }
        public override string ToString()
        {
            return $"Number: {Number}, Data: {Data}";
        }   
    }
}
