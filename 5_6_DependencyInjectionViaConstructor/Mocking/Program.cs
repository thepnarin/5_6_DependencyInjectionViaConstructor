﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_DependencyInjectionViaConstructor.Mocking
{
    public class Program
    {
        public static void Main()
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle();
        }
    }
}
