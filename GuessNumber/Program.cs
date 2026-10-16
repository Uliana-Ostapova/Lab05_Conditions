// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0) {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0) {
//     Console.WriteLine("Число отрицательное."); 
// }
// else {
//     Console.WriteLine("Число равно нулю.");
// }

// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91) {
//     Console.WriteLine("Оценка: Отлично (5)");
// }
// else if (score >= 71) {
//     Console.WriteLine("Оценка: Хорошо (4)");
// }
// else if (score >= 51) {
//     Console.WriteLine("Оценка: Удовлетворительно (3)");
// }
// else {
//     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// }

// Console.WriteLine("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл по практике: ");
// double precticeGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >= 14;
// bool goodGrades = precticeGpa >= 3.0;
// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Доступ к экзамену разрешён.");
// }
// else if (!goodAttendance && goodGrades) {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }

// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершенолетний" : "несовершенолетний";
// Console.WriteLine($"Вы {ageGroup}.");
// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");
// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "чётное" : "нечётное";
// Console.WriteLine($"Число {n} - {parity}.");

// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");
// string choice = Console.ReadLine();
// switch (choice) {
//     case "1":
//         Console.WriteLine("расписание: ИСп-244, каб. 102, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИСРПО - 20, РП - 35,");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;
// }

// Console.Write("\nВведите номер дня недели (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine());
// switch (dayNumber) {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Рабочий день - пора учиться!");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной - заслуженный отдых.");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует.");
//         break;
// }
// Console.Write("\nВведите название месяца цифрой (1-12): ");
// int monthNumber = int.Parse(Console.ReadLine());
// switch (monthNumber)
// {
//     case 1:
//     case 2:
//     case 12:
//         Console.WriteLine("Зима");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Весна");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("Лето");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("Осень");
//         break;
//     default:
//         Console.WriteLine("Такого месяца не существует");
//         break;
// }

// Random random = new Random();
// int secret = random.Next(1, 101);
// int attempts = 0;
// bool guessed = false;
// Console.WriteLine("Угадай число (1-100)");
// Console.WriteLine("Я загадал число. Попробуй угадать!");
// while (!guessed)
// {
//     Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
//     string input = Console.ReadLine();
//     if (!int.TryParse(input, out int guess))
//     {
//         Console.WriteLine("!!! Введите целое число, а не текст!");
//         continue;
//     }
//     if (guess < 1 || guess > 100)
//     {
//         Console.WriteLine("!!! Число должно быть от 1 до 100!");
//         continue;
//     }
//     attempts++;
//     if (guess < secret)
//     {
//         int diff = secret - guess;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↑ Больше {hint}\n");
//     }
//     else if (guess > secret)
//     {
//         int diff = guess - secret;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↓ Меньше {hint}\n");
//     };l
//     else {
//         guessed = true;
//     }
// }
// string result = attempts <= 7 ? $"Отличный результат! Всего {attempts} попыток." : $"Число найдено за {attempts} попыток. Можно лучше!";
// Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
// Console.WriteLine($"{result}");
// string GetHint(int difference)
// {
//     switch (difference)
//     {
//         case <= 3:
//             return "🔥 Горячо!";
//         case <= 10:
//             return "🌡 Тепло.";
//         case <= 25:
//             return "🌀 Прохладно.";
//         default:
//             return "❄ Холодно!";
//     }
// }

//№1
// Console.Write("Введите пароль: ");
// string password = Console.ReadLine();
// Console.Write("Подтвердите пароль: ");
// string confPassword = Console.ReadLine();
// if (password == confPassword)
// {
//     Console.WriteLine("Пароль принят");
// } else
// {
//     Console.WriteLine("Пароль не принят");
// }

//№2
// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine());
// if (age >= 18)
// {
//     Console.Write("Доступ разрешён");
// } else
// {
//     Console.Write("Доступ запрещён");
// }

//№3
// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());
// Console.Write("Введите операцию (+, -, *, /): ");
// string operation = Console.ReadLine();
// switch (operation)
// {
//     case "+":
//         Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
//         break;
//     case "-":
//         Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
//         break;
//     case "*":
//         Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
//         break;
//     case "/":
//         if (number2 != 0)
//         {
//             Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
//         } else
//         {
//             Console.WriteLine("На ноль делить нельзя");
//         }
//         break;
//     default:
//         Console.WriteLine("Неизвестная операция");
//         break;
// }

//№4
// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int number3 = int.Parse(Console.ReadLine());
// int sum = 0;
// if (number1 > 0)
// {
//     sum += number1;
// }
// if (number2 > 0)
// {
//     sum += number2;
// }
// if (number3 > 0)
// {
//     sum += number3;
// }
// Console.WriteLine(sum);

//№5
Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
Console.WriteLine("Путь B: Пойти по тёмному коридору.");
Console.Write("Выберите путь (А или В): ");
string choice = Console.ReadLine();
if (choice == "A")
{
    Console.WriteLine("Дракон задаёт загадку:");
    Console.WriteLine("Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.");
    Console.Write("Ваш ответ: ");
    string answer = Console.ReadLine();
    if (answer == "рыба")
    {
        Console.WriteLine("Дракон открывает дверь в следующую комнату!");
    }
    else
    {
        Console.WriteLine("Ответ неверный. Дракон вас съел!");
    }
}
else if (choice == "B")
{
    Console.WriteLine("Перед вами две двери.");
    Console.Write("Выберите дверь (1 или 2): ");
    string number = Console.ReadLine();
    if (number == "1")
    {
        Console.WriteLine("Вы нашли сокровища Dungeon Master’а!");
    }
    else if (number == "2")
    {
        Console.WriteLine("Вы попали в ловушку с ядовитыми шипами!");
    }
    else
    {
        Console.WriteLine("Такой двери нет.");
    }
}
else
{
    Console.WriteLine("Такого пути нет.");
}