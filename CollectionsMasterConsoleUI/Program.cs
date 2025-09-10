using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            // Create an integer Array of size 50

	        int[] arizzy = new int[50];
            

            //: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            
	        Populater(arizzy);

            //: Print the first number of the array
            Console.WriteLine();
            Console.WriteLine($"First number: {arizzy[0]}");


            //: Print the last number of the array            
            Console.WriteLine();
 	        Console.WriteLine("Last number: " + arizzy[49]);



            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(arizzy);
            Console.WriteLine("-------------------");

            //: Reverse the contents of the array.
            //Do this 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
                Then print BOTH reversed arrays to the console.
            */

            Console.WriteLine("All Numbers Reversed:");
	        Array.Reverse(arizzy);
            NumberPrinter(arizzy);

            Console.WriteLine("---------REVERSE CUSTOM------------");

	        ReverseArray(arizzy);
            


            Console.WriteLine("-------------------");

            //: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(arizzy); 

        
            Console.WriteLine("-------------------");

            //: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
	        Array.Sort(arizzy);
	        NumberPrinter(arizzy);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //: Create an integer List
            List<int> intList = new List<int>();

            //: Print the capacity of the list to the console
            
	        Console.WriteLine("The capacity of the list is " + intList.Capacity); 

            //: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
	        Populator(intList);
	    
	    


            

            //: Print the new capacity
	        Console.WriteLine("The updated capacity is " + intList.Capacity);
            Console.WriteLine("---------------------");

            //: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
           
            int userNumber;
            bool isNumber;

            do
            {
                Console.WriteLine("What number do you want to search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out userNumber);

            } while (isNumber == false);
            
            
       
            NumberChecker(intList, userNumber);



            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);

            Console.WriteLine("-------------------");


            //: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            NumberPrinter(intList);

	        Console.WriteLine("------------------");

            //: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            intList.Sort();
            NumberPrinter(intList);

            Console.WriteLine("------------------");

            //: Convert the list to an array and store that into a variable
            int[] listArray = intList.ToArray();

            //: Clear the list
            intList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }

            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> iList)
        {
            for (int j = iList.Count - 1; j >= 0; j--)
            {
                if (iList[j] % 2 != 0)
                {
                    iList.Remove(iList[j]);
                }
            }
            
	    

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
          
	    
		    if (numberList.Contains(searchNumber) == true)

		    {
			    Console.WriteLine("Your number is on the list.");
		    }
		    else
		    {
			    Console.WriteLine("Your number isn't on the list.");
		    }
	    

        }

        private static void Populater(int[] numbers) 
        {
            
                

	        for (int i = 0; i < numbers.Length; i++) 
            {
                Random rng = new Random(); 
                                               
                numbers[i] = rng.Next(0, 50);
            }
	      
        }

	
        private static void Populator(List<int> numberList)
        {
	    
	        while (numberList.Count < 50)
	        {
		       Random rng = new Random();
		       int rNum = rng.Next(0, 50);

                numberList.Add(rNum);
		     
	        }

        }        

        private static void ReverseArray(int[] array) 
        {
            Array.Reverse(array);
            NumberPrinter(array);
            
        }

	 
        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
