//Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = CheckDist("Введите координату X первой точки: ");
int y1 = CheckDist("Введите координату Y первой точки: ");
int z1 = CheckDist("Введите координату Z первой точки: ");
int x2 = CheckDist("Введите координату X второй точки: ");
int y2 = CheckDist("Введите координату Y второй точки: ");
int z2 = CheckDist("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние составит : {length}");


int CheckDist(string result)
{
    Console.Write(result);
    return Convert.ToInt32(Console.ReadLine());
}
