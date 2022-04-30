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

    class Ferry : Ship
    {
        public int VoyageCount { get; set; }

        public Ferry(int s) : base(s)
        {

        }
        public Ferry() : base()
        {

        }

        public override void SetValue(int val)
        {
            VoyageCount = val;
        }
        public override string ToString()
        {
            return "Ferry: Speed = "+Speed;
        }
    }
}
