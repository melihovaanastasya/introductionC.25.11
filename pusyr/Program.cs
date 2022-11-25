// Сортировка пузырьком.

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

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void BubbleSort(int[]a)
{
    for (int i=0;i<a.Length;i++)
    for (int j=0;j<a.Length-1;j++)
    if (a[j]>a[j+1])
    Swap(ref a[j], ref a[j+1]);

}

int[]a=RandomIntArray(10,0,10);
Print(a);
BubbleSort(a);
System.Console.WriteLine();
Print(a);