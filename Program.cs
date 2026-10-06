// int dayNumber = 5;

// switch (dayNumber) {
//     case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будни"); break;
// }

// int score = 78;

// switch (score)
// {
//     case >= 0 and < 39:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and < 59:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and < 79:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }


// int score = -1;

// string result = score switch
// {
//     >= 35 => "Очень жарко",
//     >= 25 => "Жарко",
//     >= 15 => "Комфортно",
//     >= 0 => "Прохладно",
//     _ => "Мороз",

// };

// Console.WriteLine(result);

// string role = "teacher";

// string result = role switch
// {
//     "teacher" => "Доступ преподавателя",
//     "admin" => "Полный доступ",
//     _ => "Ограниченный доступ"
// };

// Console.WriteLine(result);

// int age = 20;
// bool hasTicket = true;

// switch (age)
// {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }

// int level = 2;

// switch (level)
// {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }


/*
Самостоятельные задания ★
Задача
*/
// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine());

// string result = age switch
// {
//     >= 65 => "Пенсионер",
//     >= 18 and <= 64 => "Взрослый",
//     >= 7 and <= 17 => "Подросток",
//     >= 0 and <= 6 => "Ребёнок",
//     _ => "Ошибка"
// };

// Console.WriteLine(result);


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// // Вариант 2
// Console.Write("Введите число: ");
// int score = int.Parse(Console.ReadLine());

// string result = score switch
// {
//     >= 0 and <= 39 => "Неудовлетворительно",
//     >= 40 and <= 59 => "Удовлетворительно",
//     >= 60 and <= 79 => "Хорошо",
//     >= 80 and <= 100 => "Отлично",
//     _ => "Ошибка"

// };

// Console.WriteLine(result);


// //Вариант 8
// Console.Write("Введите тип транспорта: (автобус, метро, такси) ");
// string type = Console.ReadLine();

// switch (type)
// {
//     case "автобус":
//         Console.WriteLine("Наземный транспорт");
//         break;
//     case "метро":
//         Console.WriteLine("Подземный транспорт");
//         break;
//     case "такси":
//         Console.WriteLine("Индивидуальный транспорт");
//         break;
//     default:
//         Console.WriteLine("Неизвестный транспорт");
//         break;
// }


//Дополнительное задание ★★★

int number = 42;

string result = number switch
{
    1 or 2 or 3 => "Маленькое число",
    >= 0 and <= 9 => "Однозначное",
    >= 10 and <= 99 => "Двузначное",
    >= 100 => "Трёхзначное или больше",
    _ => "Отрицательное"
};

Console.WriteLine(result);