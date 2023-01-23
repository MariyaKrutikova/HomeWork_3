/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int GetCoordinate(string message){
    int result = 0;
    while(true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)){
            break;
        }
        else{
            Console.WriteLine("Введены некорректные данные. Повторите Ввод!");
        }
    }
    return result;
}

double GetDistance(int xa, int ya, int za, int xb, int yb, int zb){
    double distance = Math.Sqrt(Math.Pow(xa-xb,2)+Math.Pow(ya-yb,2)+Math.Pow(za-zb,2));
    return distance;
}

int xa = GetCoordinate("Введите координату x для точки А: ");
int ya = GetCoordinate("Введите координату y для точки А: ");
int za = GetCoordinate("Введите координату z для точки А: ");

int xb = GetCoordinate("Введите координату y для точки B: ");
int yb = GetCoordinate("Введите координату y для точки B: ");
int zb = GetCoordinate("Введите координату z для точки B: ");

double distance = GetDistance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между точками А и B составляет {distance}");
