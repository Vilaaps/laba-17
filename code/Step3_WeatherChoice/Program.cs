//Console.WriteLine("Выбор одежды по погоде");
//Console.Write("Введите текущую температуру (C)");
//int temperature = Convert.ToInt32(Console.ReadLine());
//if (temperature >= 20)
//{
//    Console.WriteLine("Наденьте легкую одежду");
//}
//else
//{
//    Console.WriteLine("Наденьте тёплую одежду");
//}
//Console.WriteLine("Хорошего дня");

Console.WriteLine("Программа выбора одежды");
Console.Write("Введите текущую температуру (C)");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
    Console.WriteLine("Наденьте лёгкую одежду (футболку, шорты, платье).");
}
else
{
    Console.WriteLine("Наденьте тёплую одежду (кофту, куртку, джинсы).");
}
Console.WriteLine("Хорошего дня!");