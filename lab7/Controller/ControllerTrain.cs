using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public class ControllerTrain
    {
        private Collection model;
        private View view;

        public ControllerTrain(Collection model, View view)
        {
            this.model = model;
            this.view = view;
        }

        public void AddTrain(int number, string destination, string name)
        {
            Train train = new Train { Number = number, Destination = destination, Name = name};
            model.AddTrain(train);
    
        }

        public void DisplayTrains()
        {
            string trainList = model.Print();
            view.DisplayTrainList(trainList);
        }
/*
        public void RemoveTrain(Train train)
        {
            model.RemoveTrain(train);
        }*/
    }

}
