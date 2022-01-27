using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    internal class Program
    {
       
    
            static void Main(string[] args)
            {
            Flipcoin Head = new Flipcoin();
            Console.WriteLine("Enter charactor");
            char alphabet = Convert.ToChar(Console.ReadLine());
            Head.vowel_consonant(alphabet);
                Console.ReadLine();

            }
        }
    }


