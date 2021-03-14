using System.IO;
using System;
using System.Linq;

class Solution
{
    static string twoStrings(string s1, string s2)
    {
        /* 97 == 'a' | 122 == 'z' */
        for (int leterAscii = 97; leterAscii <= 122; leterAscii++)
            if (s1.Contains((char)leterAscii) && s2.Contains((char)leterAscii))
                return "YES";
        return "NO";

        /* you can solve with this solution
            var alphabe = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (var letter in alphabe)
            {
                if (s1.Contains(letter) && s2.Contains(letter))
                    return "YES";
                return "NO";
            }
        */
    }

    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            Console.WriteLine(result);
        }
    }
}
