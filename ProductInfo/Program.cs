using System;
using System.Runtime.InteropServices;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

ProductInfo product1 = new ProductInfo("노트북", 1500000);
product1.PrintInfo();

ProductInfo product2 = new ProductInfo("키보드", 80000, 20);
product2.PrintInfo();

product2.DiscountPercent = 30;
product2.PrintInfo();

class ProductInfo
{
    public string name {  get; set; }
    public double price { get; set; }
    public double DiscountPercent { get; set; }
    public double DiscountAmount => price * (DiscountPercent /100);
    public double FinalPrice => price *(1-(DiscountPercent / 100));


    public ProductInfo(string name, int price)
    {
        this.name = name;
        this.price = price;
        DiscountPercent = 0;
    }
    public ProductInfo(string name, int price , int discount)
    {
        this.name = name;
        this.price = price;
        DiscountPercent = discount;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[상품 정보] {name} - 가격: {price}원, 할인: {DiscountPercent}% ({DiscountAmount}원), 최종가: {FinalPrice}원");
    }
}