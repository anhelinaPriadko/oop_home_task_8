using System;

//порушено принци підстановки Лісков
//дочірній клас змінює поведінку батьківського класу

interface IArea
{
    int GetArea();
}

class Rectangle: IArea
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IArea
{
    public int Side { get; set; }
    public int GetArea()
    {
        return Side*Side;
    }

    class Program
    {
        static void Main(string[] args)
        {
            IArea rect = new Square() { Side = 10};
            Console.WriteLine (rect .GetArea());

            rect = new Rectangle() { Width = 5, Height = 10 };
            Console.WriteLine(rect.GetArea());

            Console.ReadKey();
        }
    }
}

// помилка була в тому що ми створюємо об'єкт Rectangle але
// присвоюємо йому об'єкт Square, в якого всі методи override
// потім ми втсновлюємо ширину = 5, яка робить і довжину 5, а
// дані робимо з висотою = 10, що в свою чергу змінює й ширину,
// тому що наш об'кт має властивості саме квадрата , а не прямокутника