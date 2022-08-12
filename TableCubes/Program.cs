// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Enter number N :");
int numberN = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i < numberN; i++){
    long numCube = (long)Math.Pow(i , 3);
    System.Console.WriteLine($"таблица кубов от 1 до числа {numberN} не включительно : куб числа {i} = {numCube}");
}