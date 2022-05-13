// Задача с прошлого семинара
// Попробуем оценить, какая из сортировок оптимальнее
void SortNumbers(int[] nums)
{
    int size = nums.Length;
    int[] temp = new int[nums.Length];

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

}


int a = 123; // 1 шаг
int b = 312; // 1 шаг
int c = a + b; // 1 шаг

int n = new Random().Next(1, 1000000);

for(int i = 0; i < n; i++)
{
    c =+ i; // n шагов
}