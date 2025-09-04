using System;
using System.Collections.Generic;

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
	
	    Console.WriteLine(arizzy[0] + " is the first number in the array (this time).");

            //: Print the last number of the array            
	
 	    int end = arizzy.Length - 1;
	    Console.WriteLine(arizzy[end] + " is the last number in the array (this time).");



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
	    for (int counter = 0; counter < arizzy.Length; counter++)
	    {
		    Console.WriteLine(arizzy[counter]);
	    }

            Console.WriteLine("---------REVERSE CUSTOM------------");

	    ReverseArray(arizzy, 0, (arizzy.Length - 1));
	    Array.ForEach(arizzy, Console.WriteLine);


            Console.WriteLine("-------------------");

            //: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(arizzy); 

            Console.WriteLine("-------------------");

            //: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
	    Array.Sort(arizzy);
	    Array.ForEach(arizzy, Console.WriteLine);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //: Create an integer List
            List<int> intList = new List<int>();

            //: Print the capacity of the list to the console
            int cap = intList.Capacity;
	    Console.WriteLine("The capacity of the list is " + cap); 

            //: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
	    
	    Populator(intList);
	    intList.ForEach(Console.WriteLine);


            

            //: Print the new capacity
	    // int updatedCap = intList.Capacity; 
	    Console.WriteLine("The updated capacity is " + cap);
            Console.WriteLine("---------------------");

            //: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number do you want to search for in the number list?");
	    var input = Console.ReadLine();
	    bool testResult = int.TryParse(input, out int parsedInput);
	    if (!testResult)
	    {
		    Console.WriteLine("Numbers only please! Let's try again - what number do you want to search?");
		    input = Console.ReadLine();
		    testResult = int.TryParse(input, out parsedInput);
	    }
	    int pInput = int.Parse(input);
	    NumberChecker(intList, pInput);



            Console.WriteLine("All Numbers:");
           //UNCOMMENT this method to print out your numbers from arrays or lists
	    intList.ForEach(Console.WriteLine);
            Console.WriteLine("-------------------");


            //: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
	    intList.ForEach(Console.WriteLine);
	    Console.WriteLine("------------------");

            //: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
	    for (int q = 0; q < intList.Count; q++)
	    {
		    Console.WriteLine(intList[q]);
	    }
            Console.WriteLine("------------------");

            //: Convert the list to an array and store that into a variable
            int[] listArray = intList.ToArray();

            //: Clear the list
            intList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
           for (int i = 0; i < 50; i++)
	   {
		   if (numbers[i] % 3 == 0)
		   {
			   Console.WriteLine(numbers[i] + " is a multiple of 3 and will be removed from the list.");
			   numbers[i] = 0;
		   }

	   } 
        }

        private static void OddKiller(List<int> iList)
        {
            for (int j = 0; j < iList.Count; j++)
	    {
		if (iList[j] % 2 == 0)
		{
			Console.WriteLine(iList[j] + " is even and will be skipped.");
		}
		else
		{
			Console.WriteLine(iList[j] + " is odd and will be removed from the list.");
			iList.RemoveAt(j);	
		}
	    }
	    //return iList;

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
          
	    
		    if (numberList.Contains(searchNumber) == true)

		    {
			    Console.WriteLine("Whoop whoop! Your number is on the list.");
		    }
		    else
		    {
			    Console.WriteLine("Sorry pally, you number isn't on the list.");
		    }
	    

        }

        private static int[] Populater(int[] numbers) 
        {

	    for (int i=0; i < 50; i++)
	    {
		    Random rng = new Random();
		    int randomNumber = rng.Next();
         	    numbers[i] = randomNumber;
	    }
	    return numbers;
        }

	
        private static void Populator(List<int> numberList)
        {
	    
	    for (int j=0; j < 50; j++)
	    {
		    Random rng = new Random();
		    int rNum = rng.Next();
		    numberList.Add(rNum);
		   
	    }

        }        

        private static void ReverseArray(int[] array, int startIndex, int endIndex) 
        {
		while (startIndex > endIndex)
		{
			int temp = array[startIndex];
			array[startIndex] = array[endIndex];
			array[endIndex] = temp;

			startIndex++;
			endIndex--;
		}

			

        }

	public static void NumberPrinter(int[] arr)
	{	
		for (int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
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
