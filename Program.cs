// 1 Задание - Пользователь вводит трезначное число, а программа выводит вторую цифру числа
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if(number > 99 && number < 1000) Console.WriteLine($"Вторая цифра числа {number} -> {number/10%10}");

//2 Задание - Пользователь вводит число, программа должна выводить третью цифру числа
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = num;
if (num < -99 || num > 99){
    for(int i = 0; result > 999 || result < -999; i++){
        result/=10;
    }
    result%=10;
    Console.WriteLine($"Третья цифра числа {num} -> {result}");
}else{
    Console.WriteLine($"Третьей цифры у числа {num} нет");
}

//3 Задание - Пользователь вводит число, обозначающее день недели. Если это выходной, программавыволдит "да", если нет "нет"
Console.Write("Введите число: ");
int day = int.Parse(Console.ReadLine()!);
if(day > 0 && day < 6) Console.WriteLine("Нет, это не выходной");
else if(day > 5 && day < 8) Console.WriteLine("Да, это выходной");
else Console.WriteLine("Ошибка, введите число от 1 до 7");
