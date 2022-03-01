using System;

namespace LINQ_Practice_Models
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            Person[] person =
            {
                new Person(){ Id=1, Name= "Pranay", Address="Roha"},
                new Person(){ Id=2, Name= "", Address="Roha"},
            };
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
