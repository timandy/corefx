using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] none = "this, is, a, string, with some spaces ų".Split(new char[]{',', ' ', 's', 'Ā', 'a'},StringSplitOptions.None);

             if(none.SequenceEqual( new string[]{"thi", "", "", "i", "", "", "", "", "", "", "tring", "", "with", "", "ome", "", "p", "ce", "", "ų"}))
                 Console.WriteLine("none ok");
             
             string[] remove = "this, is, a, string, with some spaces ų".Split(new char[]{',', ' ', 's', 'Ā', 'a'},StringSplitOptions.RemoveEmptyEntries);
             if(remove.SequenceEqual(new string[]{"thi", "i", "tring", "with", "ome", "p", "ce", "ų"}))
                 Console.WriteLine("remove ok");

//
//            assertEquals(Linq.of(), Linq.split("this, is, a, string, with some spaces ų", new char[]{',', ' ', 's', 'Ā', 'a'}, StringSplitOptions.None));
//            assertEquals(Linq.of("thi", "i", "tring", "with", "ome", "p", "ce", "ų"), Linq.split("this, is, a, string, with some spaces ų", new char[]{',', ' ', 's', 'Ā', 'a'}, StringSplitOptions.RemoveEmptyEntries));
//
//            
            
            
            string[] strings = "a".Split(new char[]{' ',' ',' ',' ',' '});
         Console.WriteLine(strings);

            Console.WriteLine("Hello World!");
        }
    }
}
