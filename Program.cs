using System;

namespace GenericsHomework_MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string > myDictionary = new MyDictionary<string,string >();
           
            myDictionary.Add("gulnisa","aslan");
            myDictionary.Add("ercan", "aslan");
            myDictionary.Add("semih sercan", "aslan");
            myDictionary.Add("muhammet haşim", "aslan");
            foreach (var key in myDictionary.Key)
            {
                Console.WriteLine(key);
                
            }
            foreach (var value in  myDictionary.Value)
            {
                Console.WriteLine(value);
              
            }
          



            // Console.WriteLine("Hello World!");
        }
    }
}
