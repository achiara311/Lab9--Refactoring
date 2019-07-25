using System;
using System.Collections.Generic;

namespace RefactoringLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> student = new List<string>
            {"Andrew ", "Jon ","Jane "};

            List<string> food = new List<string>
            { "Pizza", "Pasta", "Fruit",};
            List<string> homeTown = new List<string>
            {"Detroit", "Chicago", "Los Angeles"};

            List<string> colors = new List<string>
            {"Red ", "Yellow ","Blue "};

            bool go = true;
            while (go)
            {
                try
                {
                    Console.WriteLine("Which Student would you like to see? Enter a number.\n");
                    PrintToLists(student);
                    int input = UserInputParse();

                    Console.WriteLine($"\nWhat would you like to know more about {student[input - 1]}?\n");
                    Console.WriteLine("Hometown? or Food?");
                    string input2 = Console.ReadLine().ToLower();
                    if (input2 == "hometown")
                    {
                        PrintToLists(homeTown);
                        int inputTown = UserInputParse();
                        Console.WriteLine($"\n{student[input - 1]} is from {homeTown[inputTown - 1]}\n");
                        go = Proceed();
                        Console.WriteLine($"\nWhat is {student[input - 1]}'s favorite color? Enter a number.\n");
                        PrintToLists(colors);
                        int input3 = UserInputParse();
                        Console.WriteLine($"\n{colors[input3 - 1]} is {student[input - 1]}'s favorite color!\n");
                        
                    }


                    else if (input2 == "food")
                    {
                        PrintToLists(food);
                        int inputFood = UserInputParse();
                       Console.WriteLine($"\n{student[input - 1]} really likes {food[inputFood - 1]}.\n");
                        go = Proceed();
                        Console.WriteLine($"\nWhat is {student[input - 1]}'s favorite color? Enter a number.\n");
                        PrintToLists(colors);
                        int input3 = UserInputParse();
                        Console.WriteLine($"\n{colors[input3 - 1]} is {student[input - 1]}'s favorite color!");

                    }

                    else
                    {
                        go = true;
                    }
                    ContinueWithAnotherStudent();
                    string name = GetStudentInput("\nGive me a new student name.\n");
                    student = AddToList(name, student);
                    PrintToLists(student);
                    Console.WriteLine("Which Student would you like to see?\n");
                    PrintToLists(student);
                    int repeatWithStudent = UserInputParse();

                    Console.WriteLine($"\nWhat would you like to know more about {student[repeatWithStudent - 1]}?\n");
                    Console.WriteLine("\nHometown? or Food?\n");
                    string repeatChoice = Console.ReadLine().ToLower();
                    if (repeatChoice == "hometown")
                    {
                        PrintToLists(homeTown);
                        int repeatInputTown = UserInputParse();
                        Console.WriteLine($"\n{student[repeatWithStudent - 1]} is from {homeTown[repeatInputTown - 1]}\n");
                        go = Proceed();
                        Console.WriteLine($"\nWhat is {student[repeatWithStudent - 1]}'s favorite color? Enter a number.\n");
                        PrintToLists(colors);
                        int repeatColor = UserInputParse();
                        Console.WriteLine($"\n{colors[repeatColor - 1]} is {student[repeatWithStudent - 1]}'s favorite color!\n");
                        Console.WriteLine("\nSee you later!");
                        break;
                    }
                    else if (repeatChoice == "food")
                    {
                        PrintToLists(food);
                        int repeatInputFood = UserInputParse();
                        Console.WriteLine($"\n{student[repeatWithStudent - 1]} really likes {food[repeatInputFood - 1]}.\n");
                        go = Proceed();
                        Console.WriteLine($"\nWhat is {student[repeatWithStudent - 1]}'s favorite color? Enter a number.\n");
                        PrintToLists(colors);
                        int repeatFood = UserInputParse();
                        Console.WriteLine($"\n{colors[repeatFood - 1]} is {student[repeatWithStudent - 1]}'s favorite color!");
                        Console.WriteLine("\nSee you later!");
                        break;
                    }

                    else
                    {
                        go = true;
                    }
                }

                catch (FormatException) //format try catch
                //index: range of three people
                //anything that's not 0,1,2 is a index exception (if they type number out of range when people 
                //try catch 2, put two parameters 
                {
                    Console.WriteLine("\nYou messed up, try again. hit a button\n");
                    go = true;

                }
                
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("\nYour numbers are out of range.\n");
                    go = true;
                    
                }
                
                Console.ReadKey();
            }
        }
        public static void PrintToLists(List<string> student)
        {
            int i = 1;
            foreach (string studentName in student)
            {
                Console.WriteLine($"\n{i}: {studentName}");
                i++; //incrementing as 1.Andrew 2.Jon 3.Jane
            }
        }
        public static int UserInputParse()
        {
            return int.Parse(Console.ReadLine());
        }

        public static bool Proceed()
        {
            Console.WriteLine($"Would you like to continue to find favorite color? {"{y}"} to continue. {"{n}"} to quit.");

            char response = Console.ReadKey(true).KeyChar;

            if (response == 'y')
            {
                return true;
            }

            else if (response != 'y')
            {
                return false;
            }
            else
            {
                return Proceed();
            }
        }
        public static bool ContinueWithAnotherStudent()
        {
            Console.WriteLine($"Would you like to add a new student {"{y}"} to continue. {"{n}"} to quit.");

            char response = Console.ReadKey(true).KeyChar;

            if (response == 'y')
            {
                return true;
            }

            else if (response != 'y')
            {
                return false;
            }
            else
            {
                return Proceed();
            } 
        }
        public static string GetStudentInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine(); //if it were int, add extra steps of parsing, then returning variableName
        }

        public static List<string> AddToList(string input, List<string> list) //sending it back to the List
        {
            //assessment REQUIRES to return this AS A LIST
            //adding things to the List

            list.Add(input);
            return list;
        }
    }
}




