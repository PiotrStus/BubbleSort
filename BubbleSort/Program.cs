namespace BubbleSort
{
    internal class Program
    {
        static List<int> numbersTwoSort = new List<int>();
        static int firstNumber;
        static int newNumber;
        static void Main(string[] args)
        {
            numbersTwoSort = [9, 6, 2, 4, 2, 1, 8, 1, 3];
            Console.Write("Old Bubble sort: ");
            returnList();


            for (int i = 0; i < numbersTwoSort.Count; i++)
            {
                Console.WriteLine("Numbers to compare: ");
                if ((i + 1) < numbersTwoSort.Count)
                {
                    Console.WriteLine(numbersTwoSort[i]);
                    Console.WriteLine(numbersTwoSort[i + 1]);
                }



                if (((i + 1) < numbersTwoSort.Count) && numbersTwoSort[i] > numbersTwoSort[i+1] )
                {
                    Console.WriteLine("true");
                    firstNumber = numbersTwoSort[i];
                    newNumber = numbersTwoSort[i + 1];
                    numbersTwoSort[i + 1] = firstNumber;
                    numbersTwoSort[i] = newNumber;
                    
                }
                else { 
                Console.WriteLine("false");
                }
                returnList();
            }
            Console.WriteLine();
            Console.Write("New Bubble sort: ");
            returnList();
            

        }


        static void returnList()
        {
            for (int i = 0; i < numbersTwoSort.Count; i++)
            {
                Console.Write(numbersTwoSort[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
