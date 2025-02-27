using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get ; set; }  
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }




        public void MakeEngineNoise(string engineNoise) { 
        
        
        EngineNoise = engineNoise;
            Console.WriteLine($"{Make} {Model} has an engine noise that sounds like {EngineNoise}");
        
        
        }
        public void MakeHonkNoise(string makeNoise) { 
        
        HonkNoise = makeNoise;
            Console.WriteLine($"{Make} {Model} has a horn that sounds like this: {HonkNoise}");
        
       
        }






    }
}
