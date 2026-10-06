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
//     case >= 18 when hasTicket: Console.WriteLine("Вход разрешён"); break;
//     case >= 18: Console.WriteLine("Нет билета"); break;
//     default: Console.WriteLine("Возраст не подходит"); break;
// }

int level = 2;

switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}