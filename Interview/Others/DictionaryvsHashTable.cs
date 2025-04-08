using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Others
{
    internal class DictionaryvsHashTable
    {
       public DictionaryvsHashTable()
        {
            //MyHashTable();
            MyDictionry();
        }

        private void MyDictionry()
        {
            Dictionary<int , string> tbl = new Dictionary<int , string>();
            tbl.Add(1, "apple");
            tbl.Add(2, "banana");
            tbl.Add(3, "lemon");
            tbl.Add(4, "pine");
            tbl.Add(5, "pineapple");
            tbl.Add(6, "guava");
            foreach (int key in tbl.Keys)
            {
                Console.WriteLine(key);
            }
            int key1 = 5;
            var theValue = "";
            if (tbl.ContainsKey(key1))
            {
                  theValue = tbl[key1];
            }
            Console.WriteLine(theValue);
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);
            // Read all data
            Console.WriteLine("Authors List");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }
            AuthorList.TryGetValue("Raj Beniwal", out Int16 value);
            Console.WriteLine(value);
        }
        private void MyHashTable()
        {
            Hashtable  tbl = new Hashtable();
            tbl.Add(1, "apple");
            tbl.Add(2, "banana");
            tbl.Add(3, "lemon");
            tbl.Add(4, "pine");
            tbl.Add(5, "pineapple");
            tbl.Add(6, "guava");
            //foreach (object i in tbl.Keys)
            //    Console.WriteLine(i);
            //foreach (object J in tbl.Values)
            //    Console.WriteLine(J);
            //foreach (DictionaryEntry di in tbl)
            //    Console.WriteLine("keys={0} values={1}", di.Key, di.Value);
            //Console.ReadKey();
            string key = "guava";
            if (tbl.ContainsValue(key))
            {
                Console.WriteLine($"The fruit name is {key}");
            }

        }
    }
}
