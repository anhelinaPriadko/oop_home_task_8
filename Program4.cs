using System;
//порушення принципу розділення інтерфейсу
//проблема аналогічна що і була в прикладі в презентації
//про пташок

interface IDiscountItem
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

interface IStyleItem
{
    void SetColor(byte color);
    void SetSize(byte size);
}

interface IPriceItem
{
    void SetPrice(double price);
}

class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}