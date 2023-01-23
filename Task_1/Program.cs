/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

/*int GetNewNumber(){
    Console.WriteLine("Введите пятизначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}*/

int GetNewNumber(string message){
    int result = 0;
    while(true){
    Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result / 10000 > 0 && result / 10000 < 10){
        break;
        }
        else{
            Console.WriteLine("Данные введены некорректно. Повторите ввод!");
        }
    }
    return result;
}

int number = GetNewNumber("Введите пятизначное число: ");

if (number % 10 == number / 10000 && (number / 1000) % 10 == (number / 10) % 10){
    Console.WriteLine($"Число {number} является палиндромом");
}
else{
    Console.WriteLine($"Число {number} не является палиндромом");
}
