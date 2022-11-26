// 56. Написать программу копирования массива

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int [] a=new int [size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max);
    return a;
}

void Print(int [] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}

void Copy(int[]a, int[]b)
{
    for (int i=0;i<a.Length;i++)
    b[i]=a[i];
}

int [] a=RandomIntArray(10,0,200);
Print(a);
int[]b=new int[10];
Copy(a,b);
System.Console.WriteLine();
Print(b);