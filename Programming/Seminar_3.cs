int[] SortNumbers(int[] nums)
{
    if (nums == null) return new int[0];
    int size = nums.Length;
    int[] temp = new int[nums.Length];
    for(int i = 0; i < size; i++)
    {
        temp[i] = nums[i];
    }

    // System.Array.Sort(temp);
    // Выполняем сортировку пузырьком:
    for(int i = 0; i < size-1; i++)
    {
        for(int j = 0; j < size-1; j++)
        {
            if(temp[j]>temp[j+1])
            {
                int t = temp[j];
                temp[j] = temp[j+1];
                temp[j+1] = t;
            }
        }
    }
// Код работает, но насколько он хорош?


    return temp;
}