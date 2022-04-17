namespace Sorting_Program
{
    public class Sort
    {
        public void BubbleSort(int[] sharesArray)
        {
            int n = sharesArray.Length;
            for (int i = 0; i < n - 1; i++)
                for(int j = 0; j < n - i - 1; j++)
                    if(sharesArray[j] > sharesArray[j + 1])
                    {
                        int temp = sharesArray[j];
                        sharesArray[j] = sharesArray[j + 1];
                        sharesArray[j + 1] = temp;
                    }
            return;
        }
    }
}