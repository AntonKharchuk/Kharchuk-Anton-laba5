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

    class AircraftCarrier: Ship
    {
        public int WarMissionCount { get; set; }

        string CurrentMission;

        public AircraftCarrier(int s): base(s)
        {

        }
        public AircraftCarrier() : base()
        {

        }

        public override void SetValue(int val)
        {
            WarMissionCount = val;
        }

        public void SetMission(string misson)
        {
            CurrentMission = misson;
        }

        public void GetMission()
        {
            if(CurrentMission == null)
            {
                Console.WriteLine("Aircraft Carrier has No mission");
            }
            else
            {
                Console.WriteLine("Current mission: "+ CurrentMission);

            }
        }

    }
}
