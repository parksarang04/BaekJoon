string[] input = Console.ReadLine().Split();
int A  = Convert.ToInt32(input[0]);
int B = Convert.ToInt32(input[1]);
int C = Convert.ToInt32(input[2]);


Console.WriteLine((A+B)%C);
Console.WriteLine(((A%C) + (B%C))%C);
Console.WriteLine((A*B)%C);
Console.WriteLine(((A%C) * (B%C))%C);