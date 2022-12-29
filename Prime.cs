using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
class Program
{
static void Main(string[] args) // this function defines the entry point
{
bool Prime = true;
int number1,number2;
Console.WriteLine("Enter first number");
number1=int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number number");
number2=int.Parse(Console.ReadLine());
Console.WriteLine("Prime Numbers between {0} to {1} : ",number1,number2);
for (int a = number1; a <= number2; a++) //upper limit and lower limit are defined
{
for (int b = number1; b <= number2; b++)// base logic for the primality
{
if (a != b && a % b == 0) //modulo operators employed
{
Prime = false;
break;
}
}
if (Prime)
{
Console.Write("\t" + a); //printing the correct variable
}
Prime = true;
}
Console.ReadKey(); //hold the output screen
}
}
}
