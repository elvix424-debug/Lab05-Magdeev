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


int score = -1;

string result = score switch
{
    >= 35 => "Очень жарко",
    >= 25 => "Жарко",
    >= 15 => "Комфортно",
    >= 0 => "Прохладно",
    _ => "Мороз",
    
};

Console.WriteLine(result);