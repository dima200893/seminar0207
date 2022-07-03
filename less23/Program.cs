int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int cub(int number)
{
    return number*number*number;
}

int N= InputInt("Ведите число N=");

int count = 1;
while(count<=N)
{
     int tbl = cub(count);
    Console.Write(tbl + "," );
    count++;
} 