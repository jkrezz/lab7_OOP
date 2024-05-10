using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Train
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Destination { get; set; }
    }

    public class Collection
    {
        private List<Train> trains;

        public Collection()
        {
            trains = new List<Train>();
        }

        public void AddTrain(Train train)
        {
            trains.Add(train);
        }

        public void RemoveTrain(Train train)
        {
            trains.Remove(train);
        }

        public string Print()
        {
            string result = "";
            foreach (Train nam in trains)
            {
                result += nam.Name + "\n";
            }
            return result;
        }
    }

}
