int productOfNumbers(int num)
{
    int all_sum = 1;
    for (int i = 1; i <= num; i++)
        all_sum *= i;

    return all_sum;


}
int A = int.Parse(Console.ReadLine()!);
int result = productOfNumbers(A);
Console.WriteLine(result);
