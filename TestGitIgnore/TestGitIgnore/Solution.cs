using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitIgnore
{
    public class Solution
    {
        public Solution(int a, int b)
        {
            Suma = func(a, b);
        }

        public int Suma { get; }

        private int func(int a, int b)
        {
            return (a + b);

        }



    }
}
