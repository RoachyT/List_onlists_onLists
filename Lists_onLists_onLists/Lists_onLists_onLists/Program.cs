using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_onLists_onLists
{
    class Program
    {
        //create a list of strings
        public static List<string> newList = new List<string> { "Clown Shoes", "Pepperoni Pizza", "Obsecure painting", "It was Mr. Green in the observatory with a rope!" };

        static void Main(string[] args)
        {

            Pathway();

            //allow user to print out to console the list


        }
        static void Pathway()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("What would you like to do? Press \'1\' to Sort, \'2\' to Search, \'3\' Add, \'4\' to Print and \'5\' to leave: ");
                    int choosePath = int.Parse(Console.ReadLine());
                    if (choosePath == 1)
                    {
                        SortList();
                    }
                    if (choosePath == 2)
                    {
                        SearchList();
                    }
                    if (choosePath == 3)
                    {
                        AddList();
                    }
                    if (choosePath == 4)
                    {

                        newList.ForEach(Console.WriteLine);

                    }
                    if (choosePath == 5)
                    {
                        Console.WriteLine("Goodbye");
                        Environment.Exit(0);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Number out of range");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Input not correct, please try again");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You are out of range.");
                }
            }
        }

        static void SearchList()
        {
            //search function
            Console.WriteLine("What would you like to search for?");
            string searching = Console.ReadLine();
            List<string> searchParty = newList.FindAll(i => i == searching);
            foreach(string word in searchParty)
            {
                Console.WriteLine(word);
            }
        }

        static void SortList()
        {//allow user to sort alphabetically
             newList.Sort();
            newList.ForEach(Console.WriteLine);
        }

        

        static void AddList()
        { //allow user to to add items to list
          // give the option to add a student
            while (true)
            {
               
                Console.WriteLine("Would you like to add something to the list? y/n");
                string addMe = Console.ReadLine();

                if (addMe == "y" || addMe == "yes")
                {
                    Console.WriteLine("What would you like to add:");
                    string newAdd = Console.ReadLine();
                    newList.Add(newAdd);
                    continue;

                }
                if (addMe == "n" || addMe == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid, please type y or n");
                }
            }            
        }
    }
}
