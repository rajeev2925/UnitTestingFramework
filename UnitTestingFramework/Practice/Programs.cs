using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace UnitTestingFramework.Practice
{
    [TestClass]
    public class Programs
    {
        [TestMethod]
        [TestCategory("programs")]
        public void pgm1()
        {
            string substr = null;
            string input = "aaabbccddbb";
            char c = input[0]; //a b
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i]; //a a a b
                if (c == ch)
                {
                    substr += ch;
                }
                else
                {
                    Console.Write(c + "" + substr.Length);
                    c = ch;
                    substr = null;
                    substr = substr + ch;
                }
            }
            Console.Write(c + "" + substr.Length);
        }

        [TestMethod]
        [TestCategory("programs")]
        public void pgm2()
        {
            String input = "a3b2c2d2e5";
            char c = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (Char.IsLetter(ch))
                {
                    c = ch;
                }
                else if (Char.IsDigit(ch))
                {
                    int num = ch - 48;
                    for (int j = 0; j < num; j++)
                    {
                        Console.Write(c);
                    }
                    c = ' ';
                }
            }
        }
        [TestMethod]
        [TestCategory("programs")]
        public void pgm3()
        {
            int[] no = { 1, 2, 3, 4, 5, 6, 2, 4, 6 };

            for (int i = 0; i < no.Length; i++)
            {
                for (int j = i + 1; j < no.Length; j++)
                {
                    if (no[i] == no[j])
                    {
                        no[j] = 'x';
                    }
                }
            }
            for (int i = 0; i < no.Length; i++)
            {
                if (no[i] != 'x')
                {
                    if (no[i] % 2 == 0)
                    {
                        Console.Write(no[i] + " ");
                    }
                }
            }
        }
        [TestMethod]
        [TestCategory("programs")]
        public void pgm4()
        {
            int[] num = { 1, 2, 3, 4, 5, 6 };
            int s = num.Length;
            for (int i = 0; i < num.Length; i++)
            {

                for (int j = 0; j < s; j++)
                {
                    Console.Write(num[j] + " ");
                }
                Console.WriteLine();
                s = s - 1;
            }
        }

        [TestMethod]
        [TestCategory("programs")]
        public void pgm5()
        {
            int[] num = { 1, 2, 3, 4, 5, 6 ,7};
            int s = num.Length;
            for(int i = 0; i < s; i++)
            {
                for(int j = 0; j <=i;j++)
                {
                    if(i!=j)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(num[i]);
                    }
                }
                Console.WriteLine(" ");
            }
        }
        [TestMethod]
        [TestCategory("programs")]
        public void pgm6()
        {
            int[] num = { 1, 2, 3, 1, 2, 5, 6, 7, 4, 7 };
           
            for(int i=0; i < num.Length; i++)
            {
                bool flag = false;
                for (int j=i+1; j<num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        flag=true;
                        num[j] = 222;
                        break;
                    }
                }
                if(!flag)
                {
                    if (num[i]!=222)
                    Console.Write(num[i]);
                }
            }
        }
    }
}
