using System;
using System.Collections.Generic;
using System.Text;

namespace ProgaPruct4
{
    //Створити суперклас Корабель і підкласи Воєнний корабель,
    //    Авіаносець, Фрегат, Паром.За допомогою конструктора задати
    //    швидкість кожного засобу.Визначити кількість участі у бойових 
    //    діях воєнних кораблів та кількість рейсів у пасажирських.
    //    Реалізувати метод присвоєння бойового знання воєнним кораблям.

    abstract class Ship
    {
        public int Speed { get; set; }

        public Ship()
        {
            Speed = 0;
        
        }
        public Ship(int sp)
        {
            Speed = sp;
           
        }

        abstract public void SetValue(int val);
        
    }
}
