/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);


        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("You didn't enter a number. Enter the number");
        }
    }

    return result;
}


/*Как сделать через метод? С классом Math нужно же делаь как я понимаю, а что нужно ставить после
него? В прошлой задаче мы использовали квадратный крень, а если нам не нужно его получать, что ставить?

double GenIntersection (int b1, int k1, int b2, int k2)
{
    return Math.
}*/



double b1 = GetNumber ("Enter the b1");
double b2 = GetNumber ("Enter the b2");
double k1 = GetNumber ("Enter the k1");
double k2 = GetNumber ("Enter the k2");


double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");