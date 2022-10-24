// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int[] CreateArray(int M)
{
System.Console.WriteLine($"Веедите числа {M} раз");    
int [] array = new int [M];  
for (int i = 0; i < M; i++)   
    { 
    array[i] = int.Parse(Console.ReadLine());
    i = i++;   
    }
    return array; 
} 
int ArrayPolojit(int [] array)  
{
int rezult = 0;
foreach (int element in array)     
{         
    if (element > 0) rezult++;
}     
return rezult; 
} 
string GetArray(int[] array)  
{      
string sum = string.Empty;      
for (int i = 0; i < array.Length; i++)      
    {
      sum = sum + $"{array[i]}, ";      
    }                   
    return sum;  
}   
int[] array = CreateArray(5);
System.Console.WriteLine($"Вот введенные числа: {GetArray(array)}");
System.Console.WriteLine($"Количество чисел больше 0 составляет: {ArrayPolojit(array)}");