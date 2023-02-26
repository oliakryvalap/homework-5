// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

    {
        
        {
            Random random = new Random();
            int[] arr = new int[30];
            int max=0, min=100;
            for (int i = 0; i < arr.Length; i++ )  arr[i] = random.Next(100);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
           
               for (int i = 0; i < arr.Length; i++) Console.Write(" "+ arr[i]);//выводим массив
               Console.WriteLine();
                 Console.WriteLine("max:  " + max);
                 Console.WriteLine("min  " +min);
                 Console.WriteLine("Разница максимального и минимального:  "+(max - min));
                Console.ReadKey();
        }
    }

