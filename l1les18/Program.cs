using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static void RecPermutation(char[] a, int n,  string name, List<string>Supname)
        {
            for (var i = 0; i < n; i++)
            {
                var temp = a[n - 1];
                for (var j = n - 1; j > 0; j--)
                {
                    a[j] = a[j - 1];
                }
                a[0] = temp;
                if (i < n - 1)
                {
                    string StringChange= "!";
                    for (int l = 0; l < a.Length; l++)
                    {
                        StringChange = StringChange.Insert(StringChange.Length, Convert.ToString(a[l]));

                    }
                    StringChange = StringChange.Remove(0, 1);
                    //Console.WriteLine(StringChange);

                    if(String.Compare(StringChange,name)==1)

                    if (Supname.Count <= 0) Supname.Add(StringChange);
                    else
                    {
                        if (String.Compare(Supname[Supname.Count - 1], StringChange) == 1) Supname.Add(StringChange);//меньше всех элементов в списке

                    }


                } //AddToList(a, list, repeat);
                if (n > 0) RecPermutation(a, n - 1, name,Supname);
            }
        }
        public static string BiggerGreater(string input)
        {
            if (input == null) return "initial conditions is not correct";
            int check = 0;
            foreach (char j in input)
            {
                if (j == input[0]) check++;
                if (check==input.Length) return "";
            }

            List<string> Supremum = new List<string>();
            char[] Char_input = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                Char_input[i] = input[i];
            }

            RecPermutation(Char_input, input.Length, input, Supremum);

            if (Supremum.Count > 0) return Supremum[Supremum.Count - 1];
            else return "";
        }
        //static void Main(string[] args)
        //{
        //    string input ="d,br";
        //    string rezult = BiggerGreater(input);

        //    Console.WriteLine(input + "  = исходная");
        //    Console.WriteLine(rezult + "  = искомая"); 
        //    ///
        //}
    }
}