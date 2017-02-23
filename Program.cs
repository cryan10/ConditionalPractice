/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {

        //This is just a very basic practice of if-else statement

            int x = 4;
            int y = 3;

            if (x < y)
            {
                Console.WriteLine(x + " is greater than " + y);
            }

            else
            {
                Console.WriteLine(x + " is less than " + y);
            }
       
            }
        }
    }

 */


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
class Program
{
    static void Main(string[] args)
    {
            //This program is to be used by movie theater to decide if someone is old enough to see a movie


            Console.WriteLine("Hello! How old are you?");

            int userAge = int.Parse(Console.ReadLine());
                
            if (userAge >= 17) {
                Console.WriteLine("Great! Enjoy the movie!");
                }


            else
            {
                Console.WriteLine("Go home! You are too young!");
            }
        }

        }
    }
*/

/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program is to be used to decide if someone is old enough to drive


            Console.WriteLine("Hello! How old are you?");

            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 16 && userAge < 18)
            {
                Console.WriteLine("You are finally old enough to drive!");
            }


            else if (userAge >= 18 && userAge < 120)
            {
                Console.WriteLine("Of course you can drive! You're an adult!");
            }
            

            else if (userAge < 16) {
                Console.WriteLine("You are too young; Hand over the keys.");
           }

            else
            {
                Console.WriteLine("There's no way you're that old.");
            }
        }

    }
}
*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program is to be used to decide if someone is old enough to get a drink at the bar


            Console.WriteLine("Hello! Are you over 21?");

            string userAge = Console.ReadLine();


            switch (userAge)
            {
                case "yes":
                    Console.WriteLine("Great! Can I see your ID?");
                    break;

                case "no":
                    Console.WriteLine("Thanks for being honest, but please go away.");
                    break;

            }
        }
    }
}
*/

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user for two integers. 
            //Check and see if the two integers are equal to each other. 
            //If they are, inform the user the numbers are equal. 
            //Else, inform the user the numbers are not equal


            Console.WriteLine("Hey there! Enter an integer: ");

            int firstNumber = int.Parse(Console.ReadLine());


            Console.WriteLine("Great! Now give me another integer");

            int secondNumber = int.Parse(Console.ReadLine());



            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The two integers are equal to each other!");
            }

            else {
                Console.WriteLine("Sorry, the numbers aren't equal :(");
            }
        }
    }
}

*/

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user for a number. 
            //Tell the user if that number is even or odd. 


            Console.WriteLine("Hi! Enter an integer: ");

            int userInteger = int.Parse(Console.ReadLine());



            if (userInteger % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }

            else
            {
                Console.WriteLine("This is an odd number");
            }
        }
    }
}

*/


/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number 
            //tells them if number is a positive or negative number. 
            //What happens when the user enters 0?


            Console.WriteLine("Hi! Enter a positive or negative number: ");

            int userInteger = int.Parse(Console.ReadLine());



            if (userInteger < 0)
            {
                Console.WriteLine("This is a negative number");
            }

            else if (userInteger > 0)
            {
                Console.WriteLine("This is a positive number");
            }

            else
            {
                Console.WriteLine("You entered zero. Neither a positive or negative number");
            }
        }
    }
}
*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a lowercase letter 
            //check whether letter is a vowel or consonant 


            Console.WriteLine("Please enter one lowercase letter: ");

            char letter = char.Parse(Console.ReadLine());


            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("This is a vowel");

                    break;

                default:
                    Console.WriteLine("This is a consonant");

                    break;

            }
        }
    }
}
*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user to input two integer values
            // find the greatest value of the two integers. 


            Console.WriteLine("Please enter one integer: ");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another integer: ");

            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The largest integer is " + Math.Max(firstNumber, secondNumber));

        }
    }
}
*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user to input three integer values
            // find the greatest value of the three integers. 


            Console.WriteLine("Please enter one integer: ");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another integer: ");

            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter one last integer: ");

            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The largest integer is " + Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber)));

        }
    }
}
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user to input four integer values
            // find the mean value of the four integers. 


            Console.WriteLine("Please enter one integer: ");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second integer: ");

            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a third integer: ");

            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter one last integer: ");

            int fourthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The mean value is " + ((firstNumber + secondNumber + thirdNumber + fourthNumber)/4)) ;

        }
    }
}