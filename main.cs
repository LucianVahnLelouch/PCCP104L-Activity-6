using System;
class Program
{
    public static void Main(string[] args)
    {
        SelectActivity();
        void SelectActivity()
        {
            string act;
            do
            {
                int act1;
                Console.WriteLine("Select Activity from 1-5.");
                Console.WriteLine("Activity: ");
                act = Console.ReadLine();

                if (act.ToLower() == "exit")
                {
                    Console.WriteLine("Closing Program...");
                    return;
                }
                if (!int.TryParse(act, out act1))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 - 5 or type 'exit' to close the program.");
                    Console.WriteLine(" ");
                }
                switch (act1)
                {
                    case 1:
                        ActivityOne();
                        break;
                    case 2:
                        ActivityTwo();
                        break;
                    case 3:
                        ActivityThree();
                        break;
                    case 4:
                        ActivityFour();
                        break;
                    case 5:
                        ActivityFive();
                        break;
                    default:
                        Console.WriteLine("Please input a number between 1-5");
                        Console.WriteLine(" ");

                        break;
                }
                void ActivityOne()
                {
                    string terminate = "exit";
                    decimal bills1;
                    do
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Input a number: ");
                        string bills = Console.ReadLine();

                        if (bills.ToLower() == terminate)
                        {
                            Console.WriteLine("Closing Program...");
                            Console.WriteLine(" ");
                            SelectActivity();
                            break;

                        }
                        if (!decimal.TryParse(bills, out bills1))
                        {

                            Console.WriteLine("Invalid input. Please enter a valid denomination or type 'exit' to close the program.");
                            Console.WriteLine(" ");

                            continue;

                        }

                        switch (bills1)
                        {

                            case 1:
                                Console.WriteLine("Jose Rizal is found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                            case 5:
                                Console.WriteLine("Emilio Aguinaldo is found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                            case 10:
                                Console.WriteLine("Andres Bonifacio, Apolinario Mabini is found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                            case 20:
                                Console.WriteLine("Manuel L. Quezon is found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                            case 50:
                                Console.WriteLine("Sergio Osmena is found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                            case 100:
                                Console.WriteLine("Manuel Roxas is found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                            case 200:
                                Console.WriteLine("Diosdado Macapagal is found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                            case 500:
                                Console.WriteLine("Benigno Sr. and Corazon Aquino is found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                            case 1000:
                                Console.WriteLine("Jose Abad Santos, Vicent Lim, Josefa Llanes Escoda are found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                            default:
                                Console.WriteLine("No Person is found in Php " + bills);
                                Console.WriteLine("type 'Exit' to close the program.");
                                Console.WriteLine(" ");
                                break;
                        }
                    } while (true);
                }
                void ActivityTwo()
                {
                    int num1;
                    string terminate = "exit";

                    do
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Enter a Value: ");

                        string num = Console.ReadLine();

                        if (num.ToLower() == terminate)
                        {

                            Console.WriteLine("Closing Program...");
                            SelectActivity();

                            break;

                        }
                        if (!int.TryParse(num, out num1))
                        {

                            Console.WriteLine("Invalid input. Please enter a valid number or type 'Exit' to close the program.");
                            Console.WriteLine(" ");

                            continue;

                        }
                        for (int i = 1; i <= num1; i++)
                        {
                            if (i % 3 == 0 && i % 5 > 0)
                            {
                                Console.WriteLine(i + " - Foo");
                            }
                            if (i % 3 > 0 && i % 5 == 0)
                            {
                                Console.WriteLine(i + " - bar");
                            }
                            if (i % 3 == 0 && i % 5 == 0)
                            {
                                Console.WriteLine(i + " - Foobar");
                            }
                            if (i % 3 > 0 && i % 5 > 0)
                            {
                                Console.WriteLine(i);
                            }

                        }
                        Console.WriteLine("type 'Exit' to close the program.");
                        Console.WriteLine(" ");
                    } while (true);
                }
                void ActivityThree()
                {
                    string Word;
                    string PrevWord = "";
                    do
                    {
                        Console.WriteLine(" ");
                        Console.Write("Enter word: ");
                        Word = Console.ReadLine();
                        if (Word == "exit" || Word == "Exit") break;

                        PrevWord = PrevWord + " " + Word;
                        Console.WriteLine(PrevWord.Trim());
                        Console.WriteLine("type 'Exit' to close the program.");
                        Console.WriteLine(" ");
                    } while (Word != "exit" && Word != "Exit");
                    Console.WriteLine(" ");
                    Console.WriteLine("Closing Program... ");
                    Console.WriteLine(" ");
                    SelectActivity();
                }
                void ActivityFour()
                {
                    int num;
                    string word = "";
                    do
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Enter a number:");
                        word = Console.ReadLine();

                        if (int.TryParse(word, out num))
                        {
                            if (num < 0) Console.WriteLine("Invalid number: " + num);

                            for (int i = 1; i <= num; i++)
                            {
                                for (int j = 1; j <= num - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 1; k <= 2 * i - 1; k++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("type '0' to close the program.");
                            Console.WriteLine(" ");
                        }

                        else
                        {
                            Console.WriteLine("Invalid number: " + word);
                            num = 1;
                            Console.WriteLine("type '0' to close the program.");
                            Console.WriteLine(" ");
                        }
                    } while (num != 0);

                    Console.WriteLine("Closing Program... ");
                    Console.WriteLine(" ");
                    SelectActivity();
                }
                void ActivityFive()
                {
                    int sum = 0;
                    string msg = "";
                    while (true)
                    {
                        Console.WriteLine(" ");
                        Console.Write("Enter something: ");
                        string userInput = Console.ReadLine();

                        if (userInput.ToLower() == "exit")
                        {
                            Console.WriteLine("Terminating Program...");
                            Console.WriteLine(" ");
                            SelectActivity();
                            break;
                        }

                        if (int.TryParse(userInput, out int number))
                        {
                            sum += number;
                            Console.WriteLine($"Adding {number} to {sum} = {sum}");
                            Console.WriteLine("type 'Exit' to close the program.");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            msg += userInput;
                            Console.WriteLine($"Current Message is: {msg}");
                            Console.WriteLine("type 'Exit' to close the program.");
                            Console.WriteLine(" ");
                        }
                    }



                }
            } while (act.ToLower() != "exit");

        }
    }
}