using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueStackOverflow
{
    class SportsCar : interfaceISportCar
    {
        public string Brand { get; }
        public int Speed { get; set; }
        public int MaxSpeed { get; }
        public string Status { get; }
        public int SpeedIncr { get; set; }

        public virtual bool Accelerate()
        {
            bool speedExceed = Speed + SpeedIncr > MaxSpeed;

            Speed = (speedExceed) ? Speed : Speed + SpeedIncr;

            return speedExceed;
        }

        // Implementation of OCP by adding new method as Accelerate
        public virtual bool Accelerate(bool advise)
        {
            bool speedExceeded = Speed + SpeedIncr > MaxSpeed;
            Speed = (speedExceeded) ? Speed : Speed + SpeedIncr;
            if (speedExceeded && advise && (SpeedLimit != null))
            {
                SpeedLimit(this, e);
            }
            return speedExceeded;
        }
        
        public event EventHandler SpeedLimit;

        public virtual void OnSpeedLimit(object sender,EventArgs e)
        { 
        
        }


        string[] availableBrands = new string[] { "Ferrari", "Mercedes", "BMW" };

        public SportsCar(string brand)
        {
            if (!availableBrands.Contains(brand)) return;
            else Brand = brand;

            switch(brand)
            {
                case "Ferrari":
                    MaxSpeed = 350;
                    Status = "It is Ferrari";
                    break;
                case "Mercedes":
                    MaxSpeed = 300;
                    Status = "It is Mercedes";
                    break;
                case "BMW":
                    MaxSpeed = 250;
                    Status = "It is BMW";
                    break;
            }
        }        
    }
}
