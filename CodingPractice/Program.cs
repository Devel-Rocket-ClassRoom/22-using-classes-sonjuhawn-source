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

Console.WriteLine("'''");

Calculator calculator1 = new Calculator();
Console.WriteLine($"3 + 5 =  {calculator1.Add(3, 5)}");
Console.WriteLine($"3 * 5 =  {calculator1.Multiply(3, 5)}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Player player1 = new Player();
player1.Show();
Player player2 = new Player("용사", 150);
player2.Show();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Stock price = new Stock();
price.CurrentPrice = 30;
Console.WriteLine($"주가: {price.CurrentPrice}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Product product1 = new Product();
product1.name = "노트북";
product1.price = 1500000;
Console.WriteLine($"{product1.name}: {product1.price}원 (수량: {product1.quantity})");

Console.WriteLine("'''\n");


Console.WriteLine("'''");
Circle circle1 = new Circle();
Console.WriteLine($"반지름: {circle1.Radius}, 넓이: {circle1.Area:F2}");


Console.WriteLine("'''\n");

Console.WriteLine("'''");
Monster monster1 = new Monster();
monster1.name = "고블린";
monster1.Attack();
Monster monster2 = new Monster { name = "오크"};
monster2.Attack();

Console.WriteLine("'''\n");


Console.WriteLine("'''");
Character character1 = new Character { name = "용사", level = 10, job = "전사" };

Console.WriteLine($"{character1.name} - Lv {character1.level} {character1.job}");

Console.WriteLine("'''\n");

Console.WriteLine("'''");

Person1 alice = new Person1("Alice", 25);
Person1 bob = new Person1("Bob", 30);
alice.SetFriend(bob);

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

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Multiply(int a, int b) => a * b;
}

class Player
{
    public string name;
    public int hp;
    public Player()
    {
        name = "Unknown";
        hp = 100;
    }

    public Player(string name, int hp)
    {
        this.name = name;
        this.hp = 100;
    }

    public void Show()
    {
        Console.WriteLine($"이름: {name}, 체력: {hp}");
    }
}

class Stock
{
    decimal price;

    public decimal CurrentPrice
    {
        get  { return price; }
        set  { price = value; }
    }
}

class Product
{
    public string name { get; set; }
    public int price { get; set; }
    public int quantity { get; set; } = 1;
}

class Circle
{
    public double Radius { get; } = 5;
    public double Area => Math.PI * Radius * Radius;
}

class Monster
{
    public string name;
    public int health;

    public void Attack()
    {
        Console.WriteLine($"{name}이(가) 공격합니다!");
    }
}

class Character
{
    public string name;
    public string job;
    public int level;

}


class Person1
{
    private string _name;
    private int _age;

    public Person1(string name, int age)
    {
        this._name = name;
        this._age = age;
    }

    public void SetFriend(Person1 friend)
    {
        // 현재 인스턴스를 다른 개체에 전달
        friend.PrintFriendInfo(this);
    }

    public void PrintFriendInfo(Person1 person)
    {
        Console.WriteLine($"{_name}의 친구는 {person._name}입니다.");
    }
}