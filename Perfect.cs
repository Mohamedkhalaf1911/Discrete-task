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
int number1,number2,sum=0;
Console.WriteLine("Enter first number");
number1=int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number number");
number2=int.Parse(Console.ReadLine());
Console.WriteLine("Perfect Numbers between {0} to {1} : ",number1,number2);
for (int a = number1; a < number2; a++) //upper limit and lower limit are defined
{
for (int b = 1; b < a; b++)
{
if ( a % b == 0) sum+=b;
}
if(sum==a) Console.Write("\t" + a);
sum=0;
}
Console.ReadKey(); //hold the output screen
}
}
}
