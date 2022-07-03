int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int quadro(int number)
{
    return number*number;
}

int ax=InputInt("введите координаты x точки А");
int ay=InputInt("введите координаты y точки А");
int az=InputInt("введите координаты z точки A");
int bx=InputInt("введите координаты x точки B");
int by=InputInt("введите координаты y точки B");
int bz=InputInt("введите координаты z точки B");



int distX=bx-ax;
int distY=by-ay;
int distZ=bz-az;
int summ= quadro(distX)+quadro(distY)+quadro(distZ);

double dist= Math.Sqrt(summ);

Console.WriteLine("Расстояние между A и B = " + dist);
