// Сортировка выбором.

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

void SelectSort(int[]a)
{
    int im;
    for(int i=0;i<a.Length;i++)
    {
        im=i;
        for(int j=i+1;j<a.Length;j++) if (a[im]<a[j]) im=j;
        Swap (ref a[i],ref a[im]);
    }
}

int[]a=RandomIntArray(10,0,10);
Print(a);
SelectSort(a);
System.Console.WriteLine();
Print(a);