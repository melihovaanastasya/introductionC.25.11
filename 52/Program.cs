// 52. Написать программу преобразования десятичного числа в двоичное

string DecimalToBin(int n)
{
    string s="";
    while(n!=0)
{
    //System.Console.Write(n%2);
    s=Convert.ToString(n%2)+s;
    n/=2;
}
return s;
}

System.Console.WriteLine();
System.Console.WriteLine(DecimalToBin(13));