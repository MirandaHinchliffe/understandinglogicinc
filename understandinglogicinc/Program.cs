﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandinglogicinc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = (beach && city);
            bool friendNeeds = (beach || hiking);

            bool tripDecision = (yourNeeds && friendNeeds);
            Console.WriteLine(tripDecision);

            Console.ReadKey();
        }
    }
}
