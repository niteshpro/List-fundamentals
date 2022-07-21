using System;
namespace Lists
{
    class ListDemo
    {
        public static void Main()
        {
            // list Object
            var list = new List<int>() { 1, 2, 3 };

            list.AddRange(new[] { 4, 5 });


            foreach (int item in list)
                Console.WriteLine(item);
            list.Add(1);
            Console.WriteLine("--------------");
            Console.WriteLine("index of 1: "+ list.IndexOf(1));
            Console.WriteLine("index of last 1: "+ list.LastIndexOf(1));

            foreach(int x in list)
            {
                if (x==1)
                {
                    Console.WriteLine(x);
                }
                    

            }
        }
    }
}