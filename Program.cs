int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return int.Parse(Console.ReadLine());
}


int number = ReadInt("Введите число N");
PrintNumbers(number);


void PrintNumbers(int n);
{
    if(n == 1)
        return;
   
    Console.WriteLine(n + " ");
    PrintNumbers(n-1);
}
