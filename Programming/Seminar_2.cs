// Создайте функцию, которая возвращает n-й элемент последовательности Фибоначчи
// int fibo(int n)
// {
//     if (n==1 || n == 2) return 1;
//     return fibo(n-1) + fibo(n-2);
// }

// DateTime dt = DateTime.Now;
// System.Console.WriteLine(dt);

// System.Console.WriteLine(fibo(5));

// System.Console.WriteLine(DateTime.Now);
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); //смотрим, сколько времени будет выполняться расчет
// Очень долго с помощью рекурсии вычисляются большие числа


// Решение с помощью for:
// double fibo(int n)
// {
//     if (n==1 || n == 2) return 1;
//     double a = 0;
//     double b = 1;
//     double c = 0;

//     for (int i = 1; i < n; i++)
//     {
//         c = a + b;
//         a = b;
//         b = c;
//     }
//     return c;
// }

// DateTime dt = DateTime.Now;
// System.Console.WriteLine(dt);

// System.Console.WriteLine(fibo(6));

// System.Console.WriteLine(DateTime.Now);
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// ЗАДАЧА 3. 
//Завершите решение так, чтобы оно сортировало переданные в массиве числа. 
// Если функция передает пустой массив или значение null/nil, то она должна возвращать пустой массив. 
// int[] SortNumbers(int[] nums)
// {
//     if (nums == null) return new int[0];
//     else System.Array.Sort(nums);
//     return nums;
// }
// такое решение является читерством

// Если нам дают какие-то данные(например массив), то не стоит их изменять, не оставляя исходных данных
// Решение с

// int[] SortNumbers(int[] nums)
// {
//     if (nums == null) return new int[0];
//     int size = nums.Length;
//     int[] temp = new int[nums.Length];
//     for(int i = 0; i < size; i++)
//     {
//         temp[i] = nums[i];
//     }

//     // System.Array.Sort(temp);
//     // Выполняем сортировку пузырьком:
//     for(int i = 0; i < size-1; i++)
//     {
//         for(int j = 0; j < size-1; j++)
//         {
//             if(temp[j]>temp[j+1])
//             {
//                 int t = temp[j];
//                 temp[j] = temp[j+1];
//                 temp[j+1] = t;
//             }
//         }
//     }
// // Код работает, но насколько он хорош?


//     return temp;
// }

// int[] arr = {1, 2, 3, 7, 6, 5, 4, 3};

// Console.WriteLine("arr:");
// Console.WriteLine(String.Join(' ', arr));

// int[] arrSort = SortNumbers(arr);

// Console.WriteLine("arr:");
// Console.WriteLine(String.Join(' ', arr));

// Console.WriteLine("arrSort:");
// Console.WriteLine(String.Join(' ', arrSort));