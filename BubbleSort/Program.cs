namespace BubbleSort
{
    internal class Program
    {
        static List<int> initialList = new List<int>();
        static void Main(string[] args)
        {
            initialList = [10, 5, 5, 5, 9, 11, 8, 7, 21, 6, 5, 4, 3, 2, 1];
            Console.Write("Unsorted list: ");
            DisplayList(initialList);
            List<int> finalList = SortList(initialList);
            Console.Write("Sorted list: ");
            DisplayList(finalList);
        }
        static void DisplayList(List<int> listTwoDisplay)
        {
            if (listTwoDisplay.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                for (int i = 0; i < listTwoDisplay.Count; i++)
                {
                    Console.Write(listTwoDisplay[i]);
                    Console.Write(' ');
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        static List<int> SortList(List<int> unsortedList)
        {
            List<int> sortedList = unsortedList;
            if (sortedList.Count() > 0) {
                for (int j = sortedList.Count - 1; j >= 0; j--)
                {
                    for (int i = 0; i < sortedList.Count(); i++)
                    {
                        if (((i + 1) < sortedList.Count) && sortedList[i] > sortedList[i + 1])
                        {
                            int firstPosition = sortedList[i];
                            int secondPosition = sortedList[i + 1];
                            sortedList[i + 1] = firstPosition;
                            sortedList[i] = secondPosition;
                        }
                    }
                }
            }
            return sortedList;
        }
    }
}
