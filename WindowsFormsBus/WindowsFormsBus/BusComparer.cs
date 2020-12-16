using System.Collections.Generic;

namespace WindowsFormsBus
{
    internal class BusComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is AccordionBus && y is AccordionBus)
            {
                return ComparerAccordionBus((AccordionBus)x, (AccordionBus)y);
            }
            if (x is AccordionBus && y is Bus)
            {
                return -1;
            }
            if (x is Bus && y is AccordionBus)
            {
                return 1;
            }
            if (x is Bus && y is Bus)
            {
                return ComparerBus((Bus)x, (Bus)y);
            }
            return 0;
        }

        private int ComparerBus(Bus x, Bus y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerAccordionBus(AccordionBus x, AccordionBus y)
        {
            var res = ComparerBus(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.OtherColor != y.OtherColor)
            {
                return x.OtherColor.Name.CompareTo(y.OtherColor.Name);
            }
            if (x.Accordion != y.Accordion)
            {
                return x.Accordion.CompareTo(y.Accordion);
            }
            if (x.BackDoors != y.BackDoors)
            {
                return x.BackDoors.CompareTo(y.BackDoors);
            }
            if (x.BackWindows != y.BackWindows)
            {
                return x.BackWindows.CompareTo(y.BackWindows);
            }
            return 0;
        }
    }
}