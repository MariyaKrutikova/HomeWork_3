/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int GetNumber(string message){
    int result = 0;
    while(true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result !=0){
            break;
        }
        else {
            Console.WriteLine("Введите корректные данные!");
        }
    }
    return result;
}

int number = GetNumber("Введите число: ");

int i = 1;
Console.WriteLine($"Кубы чисел от 1 до {number}:");
for (i = 1; i <= number; i++){
    double cub = Math.Pow(i, 3);
    Console.WriteLine(cub);
}
