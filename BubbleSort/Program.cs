namespace BubbleSort
{
    internal class Program
    {
        static List<int> numbersTwoSort = new List<int>();
        static void Main(string[] args)
        {
            numbersTwoSort = [10, 5, 5, 5, 9, 11, 8, 7, 21, 6, 5, 4, 3, 2, 1];
            Console.Write("Unsorted list: ");
            ReturnList();
            SortList(numbersTwoSort);
            Console.Write("Sorted list: ");
            ReturnList();
        }
        static void ReturnList()
        {
            if (numbersTwoSort.Count == 0)
            {
                Console.WriteLine(numbersTwoSort);
            }
            else
            {
                for (int i = 0; i < numbersTwoSort.Count; i++)
                {
                    Console.Write(numbersTwoSort[i]);
                    Console.Write(' ');
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        static void SortList(List<int> unsortedList)
        {
            List<int> finalList = unsortedList;
            for (int j = finalList.Count - 1; j >= 0; j--)
            {
                for (int i = 0; i < finalList.Count(); i++)
                {
                    //Console.WriteLine("Numbers to compare: ");
                    if ((i + 1) < finalList.Count)
                    {
                        //Console.WriteLine(finalList[i]);
                        //Console.WriteLine(finalList[i + 1]);
                    }
                    if (((i + 1) < finalList.Count) && finalList[i] > finalList[i + 1])
                    {
                        //Console.WriteLine("true");
                        int firstPosition = finalList[i];
                        int secondPosition = finalList[i + 1];
                        finalList[i + 1] = firstPosition;
                        finalList[i] = secondPosition;
                    }
                    else
                    {
                        //Console.WriteLine("false");
                    }
                    //returnList();
                }
            }
        }
    }
}
