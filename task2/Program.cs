// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int [] arr = new int [8];
        Random random = new Random();
        int Sum = 0;
        


        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(100,1000);
        
            if (arr.Length % 2 != 0)

            {
                 Sum += arr[i];
            }

         }
        
             
        Console.WriteLine($"сумма элементов на нечетных позициях = {Sum}");
        