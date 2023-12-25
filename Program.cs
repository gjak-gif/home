// //Выводим минимальную строку задача 3
// int [,] Create2D(int rows, int colums, int min, int max)
// {
//     int[,] array = new int[rows,colums];
//     for (int i = 0; i < rows; i++) // проход по строчкам 
//         {
//            for (int j = 0; j < colums; j++) // проход по столбцам
//            {
//                 array[i,j] = new Random().Next(min,max+1);
//            } 
//         }
//         return array;
// }

// void Print2Array (int[,] array) 
// {
//    for (int i = 0; i < array.GetLength(0); i++) // проход по строчкам 
//         {
//            for (int j = 0; j < array.GetLength(1); j++) // проход по столбцам
//            {
//                 System.Console.Write(array[i,j] + " ");
//            } 
//            System.Console.WriteLine();
//         } 
// }

// static void SumStringArray(int[,] array)
// {
// int index = 0 ,  minsum = 0;
// for (int i = 0; i < array.GetLength(0); i++) //(i+2) попадаем на четные индексы 
//          {
//              int sum = 0; // количество строк
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                    sum = sum + array [i,j];
//             }
//             if (i == 0) 
//             {
//                minsum = sum;
               
//             }
//             else if (sum < minsum)
//             {
//               minsum = sum;
//                index = i;
//             } 
// }

// string line = string.Empty;
// for (int j = 0; j < array.GetLength(1); j++)
// {
//    line += array[index, j] + " " ;
// }
// System.Console.WriteLine(line);
// }


//   int[,] myArray = Create2D(5,5,0,9); 
//   Print2Array(myArray);
//   SumStringArray(myArray);


// меняум строки местами () // Проблеме в методе void Reverse (int[,] array)!!!!!!
// НЕ ПОНИМАЮ!!!!!!!!!!!!

// int [,] Create2D(int rows, int colums, int min, int max)
// {
//     int[,] array = new int[rows,colums];
//     for (int i = 0; i < rows; i++) // проход по строчкам 
//         {
//            for (int j = 0; j < colums; j++) // проход по столбцам
//            {
//                 array[i,j] = new Random().Next(min,max+1);
//            } 
//         }
//         return array;
// }

// void Reverse (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0)-i-2; i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             int temp = array[i,j];
//             array[i,j] = array[j,i];
//             array[j,i] = temp;
//  System.Console.WriteLine(array[i,j] + " ");           
//         }
//     System.Console.WriteLine();
//     }
// }
// void Print2Array (int[,] array) 
// {
//    for (int i = 0; i < array.GetLength(0); i++) // проход по строчкам 
//         {
//            for (int j = 0; j < array.GetLength(1); j++) // проход по столбцам
//            {
//                 System.Console.Write(array[i,j] + " ");
//            } 
//            System.Console.WriteLine();
//         } 
// }

// int[,] myArray = Create2D(5,5,0,9); 
// Print2Array(myArray);
// Reverse (myArray);


// Задача 1 // Показывает ошибку с else, не понимаю почему....

Console.WriteLine("Введите строку:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец:");
int num1 = Convert.ToInt32(Console.ReadLine());

int [,] Create2D(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows,colums];
    for (int i = 0; i < rows; i++) // проход по строчкам 
        {
           for (int j = 0; j < colums; j++) // проход по столбцам
           {
                array[i,j] = new Random().Next(min,max+1);
           } 
        }
        return array;
}

 int [,] Num(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++) //(i+2) пападаем на четные индексы 
        {
   
           for (int j = 0; j < array.GetLength(1); j++) // (i+2) пападаем на четные индексы
           {
            if (num1 > i && num > j)
            Console.WriteLine("Нет Элемента");
}
else 
{
    System.Console.WriteLine(array[num,num1]);
}
}
}
    
        
void Print2Array (int[,] array) 
{
   for (int i = 0; i < array.GetLength(0); i++) // проход по строчкам 
        {
           for (int j = 0; j < array.GetLength(1); j++) // проход по столбцам
           {
                System.Console.Write(array[i,j] + " ");
           } 
           System.Console.WriteLine();
        } 
}

int[,] myArray = Create2D(5,5,0,9); 
Print2Array(myArray);

System.Console.WriteLine(Num (myArray)); 


// задачу 4 не решал, если можно сбросьте решение пожайлуста