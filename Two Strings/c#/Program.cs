using System.IO;
using System;
using System.Linq;

class Solution
{
    static string twoStrings(string s1, string s2)
    {
        for (var letterAscii = 97; letterAscii <= 122; letterAscii++)
            if (s1.Contains((char)letterAscii) && s2.Contains((char)letterAscii))
                return "YES";
        return "NO";

        /* you can also solve with this solution
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
