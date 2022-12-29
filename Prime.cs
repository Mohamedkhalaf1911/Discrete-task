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
Console.WriteLine("Prime Numbers between 1 to 100 : ");
for (int a = 2; a <= 100; a++) //upper limit and lower limit are defined
{
for (int b = 2; b <= 100; b++)// base logic for the primality
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