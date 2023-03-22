using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Game
{
    public class MathGame
    {
        private int attempts = 0;

        public void StartGame()
        {
            while (attempts < 5)
            {
                Console.WriteLine("Enter any number from 1-5: ");

                int input = 0;

                try
                {
                    input = int.Parse(Console.ReadLine());

                    if (input < 1 || input > 5)
                    {
                        throw new CustomException("Invalid input! Please enter a number from 1-5.");
                    }
                    else
                    {
                        attempts++;
                    }

                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Enter an even number.");
                            int inp = int.Parse(Console.ReadLine());
                            ValidateInput(input, inp);
                            break;
                        case 2:
                            Console.WriteLine("Enter an odd number.");
                            int inp1 = int.Parse(Console.ReadLine());
                            ValidateInput(input, inp1);
                            break;
                        case 3:
                            Console.WriteLine("Enter a prime number.");
                            int inp2 = int.Parse(Console.ReadLine());
                            ValidateInput(input, inp2);
                            break;
                        case 4:
                            Console.WriteLine("Enter a negative number.");
                            int inp3 = int.Parse(Console.ReadLine());
                            ValidateInput(input, inp3);
                            break;
                        case 5:
                            Console.WriteLine("Enter zero.");
                            int inp4 = int.Parse(Console.ReadLine());
                            ValidateInput(input, inp4);
                            break;
                        default:
                            break;
                    }

                    
                }
                catch (CustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format! Please enter a number from 1-5.");
                }
            }

            Console.WriteLine("You have played this game 5 times.");
        }

        private void ValidateInput(int input, int inp)
        {
            switch (input)
            {
                case 1:
                    if (inp % 2 == 0)
                    {
                        Console.WriteLine("Success! you entered a even number");
                    }
                    else
                    {
                        Console.WriteLine("error! you entered wrong number");
                    }
                    break;
                case 2:
                    if (inp % 2 == 1)
                    {
                        Console.WriteLine("Success! you entered a odd number");
                    }
                    else
                    {
                        Console.WriteLine("error! you entered wrong number");
                    }
                    break;
                case 3:
                    if (IsPrime(inp))
                    {
                        Console.WriteLine("Success! you entered a prime number");
                    }
                    else
                    {
                        Console.WriteLine("error! you entered wrong number");
                    }
                    break;
                case 4:
                    if (inp<0)
                    {
                        Console.WriteLine("Success! you entered a negative number");
                    }
                    else
                    {
                        Console.WriteLine("error! you entered wrong number");
                    }
                    break;
                case 5:
                    if (inp==0)
                    {
                        Console.WriteLine("Success! you entered zero");
                    }
                    else
                    {
                        Console.WriteLine("error! you entered wrong number");
                    }
                    break;
            }
        }
       

        private bool IsPrime(int number)
        {
            if (number == 1 || number == 0)
                return false;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
