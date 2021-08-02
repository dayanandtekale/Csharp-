using System;

namespace CsharpFinal

{

public class poly1

{

public static void Main(string[] args)

{

poly1 obj = new poly1();
int ans1= obj.add(12, 3);

int ans2=add(45);

int ans3=add(24.3f);

System.Console.WriteLine($"Answer1 {ans1} , Answer2 {ans2}, Answer3{ans3}");

}

int add (int a , int b)

{ 
return (a+b);
}

static int add (int a)
{return (a+10);
}


static int add (float a)

{

int ans= (int)(a+20.3f);

return ans;

}

}

}