int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int number = InputInt("Введите число = ");
int num1=number / 10000;
int num2= (number / 1000)%10;
int num4= (number / 10)%10;
int num5= number % 10;

if(num1==num5 && num2==num4)
{
    Console.Write("Число палиндром");
}
else
{
    Console.Write("Число не полиндром");
}
