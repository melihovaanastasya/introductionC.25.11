// 51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

void Morezero(int[] a, int s = 0)
{
    for (int i = 0; i < a.Length; i++)
        if (a[i] > 0) s++;
    System.Console.WriteLine($"Количество чисел больше 0 - {s}");
}

void Read(int[]a)
{
    for (int i=0;i<a.Length;i++)
    a[i]=Convert.ToInt32(Console.ReadLine());
}

int s=0;
int N=Convert.ToInt32(Console.ReadLine());
int[]a=new int[N];
Read(a);
Morezero(a, s);



