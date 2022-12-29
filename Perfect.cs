using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CheckPerfect
{
    static bool IsPerfect(int number)
    {
        int sum     = 0;
        int iLoop   = 0;

        for (iLoop = 1; iLoop < number; iLoop++)
        {
            if (number % iLoop == 0)
                sum = sum + iLoop;
        }

        if (sum == number)
        {
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        int     number  = 0     ;
        bool    ret     = false ;

        Console.Write("Enter the integer number: ");
        number = int.Parse(Console.ReadLine());

        ret = IsPerfect(number);

        if (ret)
            Console.WriteLine("Given number is perfect number");
        else
            Console.WriteLine("Given number is not perfect number");
    }
}