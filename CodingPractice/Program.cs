using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Console.WriteLine("'''");
ClassName.MemberName();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Square.GetName();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
MyFirstClass.StaticMethod();
MyFirstClass instance = new MyFirstClass();
instance.InstanceMethod();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Person person1 = new Person();
person1.Name = "홍길동";
person1.Age = 25;
person1.Introduce();

Person person2 = new Person();
person1.Name = "김철수";
person1.Age = 30;
person2.Introduce();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Point point1 = new Point();
point1.X = 1;
point1.Y = 2;

Point point2 = point1;
point2.X = 100;
Console.WriteLine($"point1.X = {point1.X}");
Console.WriteLine($"point1.X = {point2.X}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
PointStruct pointStruct1 = new PointStruct();
pointStruct1.x = 10;
PointStruct pointStruct2 = pointStruct1;
pointStruct2.x = 20;
Console.WriteLine($"구조체: ps1.X = {pointStruct1.x}, ps2.X = {pointStruct2.x}");
PointClass pointClass1 = new PointClass();
pointClass1.x = 10;
PointClass pointClass2 = pointClass1;
pointClass2.x = 20;
Console.WriteLine($"클래스ps1.X = {pointClass1.x}, ps2.X = {pointClass2.x}");

Console.WriteLine("'''\n");

class ClassName
{
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }
}

class Square
{
    public static void GetName()
    {
        Console.WriteLine("정사각형");
    }
}

class MyFirstClass
{
    public static void StaticMethod() 
    {
        Console.WriteLine("[1] 정적 메서드");
    }

    public void InstanceMethod()
    {
        Console.WriteLine("[2] 인스턴스 메서드");
    }
}

class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, {Name}입니다. {Age}살입니다.");
    }
}

class Point
{
    public int X ; 
    public int Y ; 
}

struct PointStruct
{
    public int x;
    public int y;
}
class PointClass
{
    public int x;
    public int y;
}