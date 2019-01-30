using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08继承
{
    public class Driver:Person
    {
        private int _driveTime;
        public int DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }
        public void Drive()
        {
            Console.WriteLine("司机会开车");
        }
        public Driver(string name, int age, char gender, int drivetime) : base(name, age, gender)
        {
            this.DriveTime = drivetime;
        }
    }
}
