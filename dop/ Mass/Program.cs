// инициализация массива 
/*
int[] myArray; // тип данных, имя массива 
myArray = new int[5]; //5 - кол-во элементов 
// или int[]myArray = new int[5]; 
// или int[]myArray = new int[5]{1, 3, 4, 3, 5}; 
// или int[]myArray = new int[]{1, 4, 3, 5}; не уточняем, сколько эл. в массиве
// или int[]myArray = {1, 3, 4}; 
// или int[]myArray = Enumerable.Repeat(5, 10).ToArray(); 5 -это сам элемент, а 10 это колличество этих элементов.(создается 10 элементов со значением 5) 
// или int[]myArray = Enumerable.Range(4,5).ToArray(); 4 - это стартовое число, а 5 - кол-во элементов (в результате массив = 4,5,6,7,8)

myArray[1] = 3;
myArray[0] = 10;
int a = myArray[0];

System.Console.WriteLine(myArray.Length);

*/
// Массив в обратном порядке 
/*
int[] myArray = {1, 56, 69, 7};
System.Console.WriteLine("\n Вывод массива:");
for (int i = myArray.Length -1; i >= 0; i--)
{
   System.Console.WriteLine(myArray[i]); 
}
System.Console.WriteLine();
*/

//многомерные массивы 
// инициализация массива 

//int[,] myArr = new int [3, 5];
/*int[,] myArr = 
{
    {1,4,6,8,9},
    {3,4,5,6,7},
    {5,4,3,5,3}
};
*/
/*
int[,] myArr = new int [3, 5] 
{
    {1,4,6,8,9},
    {3,4,5,6,7},
    {5,4,3,5,3}
};
foreach(var item in myArr)
{
    System.Console.Write(item + " "); // выыод всех эл. массива в строку
    
}
*/
/*
int[,] myArr = new int [3, 5] 
{
    {1,4,6,8,9},
    {3,4,5,6,7},
    {5,4,3,5,3}
};
*/
// System.Console.WriteLine(myArr.Rank); выводит колличество измерений массива
// вывод массива в консоль
/*
int height = myArr.GetLength(0);
int width = myArr.GetLength(1);

for (int y = 0; y < height; y++)
{
   for (int x = 0; x < width; x++)
   {
    System.Console.Write(myArr[y, x] + "\t");
   } 
   System.Console.WriteLine();
}
*/
// заполнение двумерного массива 

/*
int [,] Array = new int [10, 6];
Random random = new Random(); //генерация рандомного массива 
for (int i = 0; i < Array.GetLength(0); i++)
{
   for (int j = 0; j < Array.GetLength(1); j++)
   {
    Array[i, j] = random.Next(0, 10); 
    
   } 
   
}
for (int i = 0; i < Array.GetLength(0); i++)
{
   for (int j = 0; j < Array.GetLength(1); j++)  // вывод массива
   {
    System.Console.Write(Array[i,j] + "\t");
   } 
   System.Console.WriteLine();
}
*/




string [,] Array = new string [2, 3];

for (int i = 0; i < Array.GetLength(0); i++)
{
   for (int j = 0; j < Array.GetLength(1); j++)
   {
    System.Console.WriteLine("y: " + i + " x: " + i);
    Array[i, j] = Console.ReadLine();
   } 
   
}
System.Console.WriteLine();

for (int i = 0; i < Array.GetLength(0); i++)
{
   for (int j = 0; j < Array.GetLength(1); j++)  // вывод массива
   {
    System.Console.Write(Array[i,j] + "\t");
   } 
   System.Console.WriteLine();
}
