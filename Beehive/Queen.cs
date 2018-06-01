using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int numberOfShifts)
        {

            for (int i = 0; i < workers.Length; i++)
                if (workers[i].doThisJob(job, numberOfShifts))
                    return true;
            return false;
        }

        public string workTheNextShift()
        {
            shiftNumber++;
            string report = "Raport zmiany numer " + shiftNumber + "\r\n";
            for(int i=0; i < workers.Length; i++)
            {
                if (workers[i].didYoufinish())
                    report += "Robotnica numer:" + (i + 1) + " zakończyła swoje zadanie \r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Robotnica numer " + (i + 1) + "nie pracuje \r\n";
                else
                    report += "Robotnica numer " + (i + 1) + " zakończy " + workers[i].CurrentJob + " po tej zmianie\r\n";

            }

            return report;
        }

    }
}
