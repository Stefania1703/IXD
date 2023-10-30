using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD
{
    public class Car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;
        public Car(string modelName, string colorName, int yearValue, int maxSpeedValue)
        {
            color = colorName;
            name = modelName; 
            maxSpeed = maxSpeedValue;
            year = yearValue;

        }
        public Car(string modelName)
        {
            name = modelName;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }

    }
}
