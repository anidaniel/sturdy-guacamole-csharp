using System;

namespace Test_project
{
    public class DataTypes
    {
        public int x;
        public int y;

        public int summation(int x,int y)
        {
            return x+y;
        }
    }

    static void Main(string[] args)
    {
        DataTypes obj1 = new DataTypes();
        //DataTypes data;  //object creation
        int sum = obj1.summation(5,2);
        Console.WriteLine("Summation: {0}", sum);
        Console.ReadLine();
    }
}