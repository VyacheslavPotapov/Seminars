int x, y;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0){
    Console.WriteLine("x = (0, +~)");
    Console.WriteLine("y = (0, +~)");
}
if (x < 0 && y > 0){
    Console.WriteLine("x = (-~, 0)");
    Console.WriteLine("y = (0, +~)");
}
if (x < 0 && y < 0){
    Console.WriteLine("x = (-~, 0)");
    Console.WriteLine("y = (-~, 0)");
}
if (x > 0 && y < 0){
    Console.WriteLine("x = (0, +~)");
    Console.WriteLine("y = (-~, 0)");
}
