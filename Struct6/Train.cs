using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct6
{
    struct Train
    {
        string destination;
        public int numberTrain { get; set; }
        TimeSpan departTime;

        public void AddTrain(string destination, int numberTrain, TimeSpan departTime)
        {
            this.destination = destination;
            this.numberTrain = numberTrain;
            this.departTime = departTime;
        }

        public override string ToString()
        {
            return (string.Format("{0}, {1}, {2}", numberTrain, destination, departTime));
        }
    }

}
