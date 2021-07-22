using System;

namespace ConsoleApp1
{
    public delegate void Del(object о); // объявление делегата
    class Subj  // класс-источник
    {
        Del dels;   // объявление экземпляра делегата
        public void Register(Del d) // регистрация делегата
        {
            dels += d;
        }
        public void OOPS()   // что-то произошло
        {
            Console.WriteLine("OOPS!");
            if (dels != null) dels(this);
        }// оповещение наблюдателей
    }


    class ObsA  // класс^аблюдатель
    {
        public void Do(object о)    // реакция на событие источника
        {
            Console.WriteLine("Вижу, что OOPS!");
        }
    }
    class ObsB  // класс-наблюдатель
    {
        public static void See(object о)    // реакция на событие источника
        {
            Console.WriteLine("Я тоже вижу, что OOPS!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Subj s = new Subj(); //объект класса-источника
            ObsA ol = new ObsA();

            ObsA o2 = new ObsA(); //объекты класса-наблюдателя
            s.Register(new Del(ol.Do)); //регистрация методов
            s.Register(new Del(o2.Do)); //наблюдателей в источнике
            s.Register(new Del(ObsB.See)); //(экземпляры делегата )
            s.OOPS(); //инициирование события
        }
    }
}