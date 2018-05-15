using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole
{
    class RabbitHole
    {
        static void Main()
        {
            var obstacles = Console.ReadLine().Split(' ').ToList();
            var energy = int.Parse(Console.ReadLine());
            Console.WriteLine( GetFinalMassage(obstacles, energy));
        }

        private static string GetFinalMassage(List<string> obstacles, int energy)
        {
            var resultMassage = string.Empty;
            var myEnergy = energy;
            var currentIndex = 0;
            var lastBomb = false;
            while(myEnergy > 0)
            {
                var currentObstacles = obstacles[currentIndex].Split('|');
                var obstacle = currentObstacles[0];
                lastBomb = false;

                if (obstacle == "RabbitHole")
                {
                    resultMassage = "You have 5 years to save Kennedy!"; break;
                }
               
                var energyLoss = int.Parse(currentObstacles[1]);

                if(obstacle == "Left")
                {
                    currentIndex = Math.Abs((currentIndex - energyLoss)) % obstacles.Count;
                    myEnergy -= energyLoss;
                }
                else if(obstacle == "Right")
                {
                    //iterate through list Count(all indexes). This way if I am the outside bounds of the list still i will have right index at the end.  
                    currentIndex = (currentIndex + energyLoss) % obstacles.Count;
                    myEnergy -= energyLoss;
                }
                else if(obstacle == "Bomb")
                {
                    obstacles.RemoveAt(currentIndex);
                    currentIndex = 0;
                    myEnergy -= energyLoss;
                    lastBomb = true;
                }
               
                if(obstacles[obstacles.Count -1] != "RabbitHole")
                {
                    obstacles.RemoveAt(obstacles.Count-1);
                }
                obstacles.Add("Bomb|" + myEnergy);
            }

            if(myEnergy <= 0 && lastBomb)
            {
                resultMassage = "You are dead due to bomb explosion!";
            }
            else if (myEnergy <= 0  && !lastBomb)
            {
                resultMassage = "You are tired. You can't continue the mission.";
            }
            
            return resultMassage;
        }
    }
}
