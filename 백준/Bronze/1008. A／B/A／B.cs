using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        //1. int 부분을 double로 바꾼다.
        
        Console.WriteLine((double)A / B);
        //2. 위의 int는 그대로 두고 출력에서 캐스팅으로 바꾼다.
        
    }
}