using InterviewPrep.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //    mydel();

            //  IsPalindrone();
            //FizzBuzz();
            //ReverseString();
            //FindFirstNonRepeated1();
            // AnagramChecker();
            //RemoveDuplicate();
            //CountWordOccurrences1();
            // FrequentlyUsedWord();
            EqualTo13();
        }
      private void EqualTo13()
        {
            int[] nums = { 2, 7, 11, 15, 9, 4 };
            int target = 13;
            int[] result = TwoSum(nums, target);

            if (result != null)
            {
                Console.WriteLine($"Indices: {result[0]}, {result[1]}");
                Console.WriteLine($"Values: {nums[result[0]]}, {nums[result[1]]}");
            }
            else
            {
                Console.WriteLine("No two numbers found");
            }

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            // Create a dictionary to store the values and their indices.
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            // Iterate through the array and check if the complement of the current value exists in the dictionary.
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // If the complement exists, return the indices of the current value and the complement.
                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[complement], i };
                }

                // Otherwise, add the current value and its index to the dictionary.
                numMap[nums[i]] = i;
            }

            // If no two numbers are found, return null.
            return null;
        }
        public async void GetUserName(string userId )
        {
            string xx =  await RunAsync(userId);
            Task.Delay(1000); // Simulate DB call
             // $"User_{userId.ToString()}";
        }
        private Task<string> RunAsync(string message)
        {
            return Task.Run<string>(() => LongRunningThread(message));

        }
        private string LongRunningThread(string message)
        {
            Thread.Sleep(1000);
            return "Hello: " + message;
        }
        private int MyTask()
        {
            return 0;
        }
        private void FrequentlyUsedWord()
        {
            string para = "Hello world This is a great world, This World is simply great".ToLower().Replace(".","").Replace(",","");
            string[] mystr = para.Split(' ');
            var res = from v in mystr
                      group v by v into
                      g
                      orderby g.Key descending
                      
                      select new
                      {
                          Name = g.Key,
                          Count = g.Count(),
                      };
            int x = 1;
            string selnm = "";
            int cnt = 0;
            foreach (var v in res) { 
                if(v.Count > x)
                {
                    selnm= v.Name;
                    cnt = v.Count;
                    x= v.Count;
                }
             }
            Console.WriteLine($"The word {selnm} occured most number of time by {cnt} ");

        }
        private void CountWordOccurrences1()
        {
            string para = "Ram and Shyam, went to mela but Ram did not eat anything";
            string word = "Ram";
            int res = CountWordOccurrences(para, word);
            Console.WriteLine($"In para { para } the word {word} occured {res} times");
        }
        public static int CountWordOccurrences(string paragraph, string word)
        {
            // Remove punctuation and convert both the paragraph and the word to lowercase
           // paragraph = Regex.Replace(paragraph, @"\p{P}", " ").ToLower();
            paragraph = paragraph.ToLower();
            word = word.ToLower();

            // Split the paragraph into words
            string[] words = paragraph.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Count the occurrences of the word
            int count = 0;
            foreach (string currentWord in words)
            {
                if (currentWord == word)
                {
                    count++;
                }
            }

            return count;
        }
        private void RemoveDuplicate()
        {
            int[] s = { 1, 2, 3, 3, 4 };
            int[] q = s.Distinct().ToArray();
            Console.WriteLine(String.Join(", ", q));
        }
        private void AnagramChecker()
        {
            string str = "silent";
            string str1 = "listen";
            if (String.Concat(str.OrderBy(c => c)).Equals(String.Concat(str1.OrderBy(c => c)))) {
                Console.WriteLine($"For string {str} and {str1} is a Anagram");

            }
            else {
                Console.WriteLine($"For string {str} and {str1} is not a Anagram");

            }
          
            
        }


        private void FindFirstNonRepeated1()
        {
            string testString1 = "abccdea";
            char firstNonRepeat1 = FindFirstNonRepeated(testString1);
            Console.WriteLine("First non-repeated character in '" + testString1 + "': " + firstNonRepeat1); // Output: a

        }
        public static char FindFirstNonRepeated(string input)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Count character frequencies
            foreach (char c in input)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            // Find the first non-repeated character
            foreach (char c in input)
            {
                if (charCounts[c] == 1)
                {
                    return c;
                }
            }

            // If no non-repeated character found, return null or a default character
            return '\0'; // Return null character if no non-repeating character is found
        }


        private void ReverseString()
        {
            string str = "ameoba";
            string res = Reverse(str);
            Console.WriteLine($"For strin { str } its reverse is {res}");
        }


        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private void FizzBuzz()
        {
            int n = 100;
            List<string> res = GfG.fizzBuzz(n);
            foreach (string s in res)
                Console.Write(s + " ");
        }
        private void IsPalindrone()
        {
            bool res = false;
            string content = "racecar";
            res = content.SequenceEqual(content.Reverse());
            Console.WriteLine($"String { content } is palindrone. Statement is {res}  ");


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


static class GfG
{
    public static List<string> fizzBuzz(int n)
    {
        List<string> res = new List<string>();

        // Loop from 1 to n (inclusive)
        for (int i = 1; i <= n; ++i)
        {

            // Check if i is divisible by both 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
            {

                // Add "FizzBuzz" to the result list
                res.Add("FizzBuzz");
            }

            // Check if i is divisible by 3
            else if (i % 3 == 0)
            {

                // Add "Fizz" to the result list
                res.Add("Fizz");
            }

            // Check if i is divisible by 5
            else if (i % 5 == 0)
            {

                // Add "Buzz" to the result list
                res.Add("Buzz");
            }
            else
            {

                // Add the current number as a string to the
                // result list
                res.Add(i.ToString());
            }
        }
        return res;
    }
}
