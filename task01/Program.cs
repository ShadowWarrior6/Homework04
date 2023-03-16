int Alaba(int num )
{
    int all_Alaba = 0;
    for   (int i = 1; i<=num; i++ )
        all_Alaba +=i;


        return all_Alaba;
}

int A =int.Parse(Console.ReadLine()!);
int result = Alaba(A);
Console.WriteLine(result);