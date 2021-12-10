using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_project
{
    class TrainComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            // Электровоз всегда главнее
            if (x is Electric_locomotive && y is Train)
            {
                return -1;
            }
            if (x is Train && y is Electric_locomotive) 
            {
                return 1;
            }
            

            if (x is Electric_locomotive && y is Electric_locomotive)
            {
                return ComparerElectricLocs((Electric_locomotive)x, (Electric_locomotive)y);
            }
            if (x is Train && y is Train) 
            {
                return ComparerTrain((Train)x, (Train)y);
            }
            return 0;
        }
        private int ComparerTrain(Train x, Train y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.LowerColor != y.LowerColor)
            {
                int test = x.LowerColor.Name.CompareTo(y.LowerColor.Name);
                return test;
            }
            if (x.UpperColor != y.UpperColor)
            {
                return x.UpperColor.Name.CompareTo(y.UpperColor.Name);
            }
            return 0;
        }
        private int ComparerElectricLocs(Electric_locomotive x, Electric_locomotive y)
        {
            var res = ComparerTrain(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.ColColor != y.ColColor)
            {
                return x.ColColor.Name.CompareTo(y.ColColor.Name);
            }
            if (x.Collector != y.Collector)
            {
                return x.Collector.CompareTo(y.Collector);
            }
            if (x.Battery != y.Battery)
            {
                return x.Battery.CompareTo(y.Battery);
            }
            return 0;
        }
    }
}
