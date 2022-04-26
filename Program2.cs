using System;

namespace its.linq
{
    public class Program2
    {
        static void Main(string[] args)
        {
            // Language-intergrated-query(linq)

            //define a data source
            string[] names = {"anna", "oi", "chenai", "rudo", "maidei"};             //define the query expression
            var namesLongerThan5 = from n in names
                                    where n.Length >= 5
                                    select n;
            //execute the query
            // foreach(string name in namesLongerThan5){ Console.WriteLine(name); }

            int[]numbs = {2,4,5,7,81,37,86};
            var EvenNumbers = from n in numbs
                            where (n % 2) == 0
                            select n;
            var totalNumber = EvenNumbers.Count();
            Console.WriteLine(totalNumber);

            // to force immediate excution you call ToList, ToArray methods
            string[] namesGirls = {"anna", "betty", "janny", "eggy"};
            string[] namesContainsA = (from n in namesGirls
                                    where n.Contains("a")
                                    select n).ToArray();
            List<string> namesContainsE = (from a in namesGirls
                                    where a.Contains("e")
                                    select a).ToList();


            // Obtaining a Data Source
            var namenames = from n in namesGirls
                            select n;

            // Filtering
            var friendBetty = from n in namesGirls
                            where n == "betty"
                            select n;
            // foreach(string n in friendBetty){ Console.WriteLine(n); }
            var mates = from n in namesGirls
                        where n.StartsWith("j") && n.EndsWith("y")
                        select n;
            // foreach(string n in mates){  Console.WriteLine(n); }


            // Ordering
            var girlsOrder = from n in namesGirls
                            where n.Length > 1
                            orderby n ascending
                            select n;
            // foreach(string n in girlsOrder){ Console.WriteLine(n); }


            // Grouping
            
        }
    }
}