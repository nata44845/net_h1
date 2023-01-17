Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i=2;
while (i<N)
{
    Console.Write(i);
    if (i<N && i+1<N) Console.Write(", ");
    i+=2;
}

if (N>1 && N%2==0) Console.WriteLine(N);
