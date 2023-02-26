// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


{

        int [] arr = new int [4];
        Random random = new Random();
        int count = 0;
        


        for (int i = 0; i < arr.Length; i++);
        {
            arr[i] = random.Next(100,1000);
        {
            if (arr.Length % 2 != 0)
           
                 count ++;
        }
 
        foreach (var item in arr)
             {
         Console.WriteLine($"{item}\t");
        }         
        
           
        Console.WriteLine($"Количество четных элементов = {count}");
        }  
}