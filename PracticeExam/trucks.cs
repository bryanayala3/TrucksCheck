using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExam
{
    internal class Trucks
    {
        public string recordId;
        public string truckId;
        public string dateMeasured;
        public double grossWeight;
        public string tareWeight;
       


        public Trucks(int record, int truck,double gross, double tare, DateTime date)
        {
            recordId=record.ToString();
            truckId=truck.ToString();  
            grossWeight=gross;
            tareWeight=tare.ToString();
            dateMeasured=date.ToString("MMMM dd, yyyy");
        }
    }
}
