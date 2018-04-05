using System;

namespace pgdbfirst
{
    public class Program
    {
        static void Main(string[] args)
        {

                  using (var db = new testdbContext())
                      {

                          foreach (var sandboxItem in db.Sandbox)
                          {
                              Console.WriteLine(sandboxItem.Name);
                          }
                      }

                      Console.WriteLine("------------------------------");


        }
    }
}
