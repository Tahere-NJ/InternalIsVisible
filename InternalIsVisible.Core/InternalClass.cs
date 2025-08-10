using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalIsVisible.Core
{
    internal class InternalCalculator
    {
        internal int Add(int a, int b) => a + b;

        internal static string SecretMessage => "This is normally hidden!";
    }
}
