using InterviewPrep.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Others
{
    internal class Examples
    {
        public Examples() {
            //Findingmissing();
            //HowManyTimesNumberOccur();
            //HowManyTimesNumberOccurDictionary();
            //Testforcharacters();
            mydel();
        }
        delegate void Printer();

        private void mydel()
        {
            List<Printer> printers = new List<Printer>();
            int i = 0;
            for (; i < 10; i++)
            {
                printers.Add( delegate { Console.WriteLine(i); });
            }
            foreach (var printer in printers)
            {
                printer();
            }
        }

        private void Findingmissing()
        {
            List<int> x = new List<int>() { 6, 2, 4, 1, 9, 7, 3, 10, 15, 19, 11, 18, 13, 22, 24, 20, 27, 31, 25, 28 };
            foreach (int xx in x.FindMissing())
            { Console.WriteLine(xx); }
        }


        private void HowManyTimesNumberOccur()
        {
            //int[] values = new[] { 1, 2, 3, 4, 5, 4, 4, 3 }; 
            int[] values = new[] { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };

            var groups = values.GroupBy(v => v);
            foreach (var group in groups)
                Console.WriteLine("Value {0} has {1} items", group.Key, group.Count());
            Console.ReadKey();
        }
        private void HowManyTimesNumberOccurDictionary()
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            Console.ReadKey();
        }

        private string InverseCharacters(string text)
        {

            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(text.ToString().ToLower());
            StringBuilder builder = new StringBuilder(text.Length);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                    builder.Append(text[i].ToString().ToUpper());
                else
                    builder.Append(text[i]);
            }

            return builder.ToString();



        }
        private void Testforcharacters()
        {
            while (true) // Loop indefinitely 
            {
                Console.WriteLine("Enter input:"); // Prompt 
                string line = Console.ReadLine(); // Get string from user 
                if (line == "e") // Check string 
                {
                    break;
                }

                Console.Write("You typed "); // Report output 
                                             //   Program prg = new Program(); 
                                             //  Console.Write(prg.InverseCharacters(line)); 
                Console.Write(InverseCharacters(line));
                Console.Write(Environment.NewLine); // Report output 
                Console.Write("You typed "); // Report output 
                Console.Write(line.Length);
                Console.WriteLine(" character(s)");
            }



        }


    }


    public static class clsFindMissing
    {
        public static IEnumerable<int> FindMissing(this List<int> list)
        {
            // Sorting the list
            list.Sort();
            // First number of the list
            var firstNumber = list.First();
            // Last number of the list
            var lastNumber = list.Last();
            // Range that contains all numbers in the  interval
            // [ firstNumber, lastNumber ]
            var range = Enumerable.Range(firstNumber, lastNumber - firstNumber);
            // Getting the set difference
            var missingNumbers = range.Except(list);
            return missingNumbers;
        }
    }

}
