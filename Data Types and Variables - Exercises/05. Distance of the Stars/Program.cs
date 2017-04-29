namespace _05.Distance_of_the_Stars
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            decimal earthToStar = 4.22M;
            decimal centerOfGalaxy = 26000M;
            decimal diameterOfMilkyWay = 100000M;
            decimal earthToUniverse = 46500000000M;
            decimal oneLightYear = 9450000000000M;
            earthToStar *= oneLightYear;
            centerOfGalaxy *= oneLightYear;
            diameterOfMilkyWay *= oneLightYear;
            earthToUniverse *= oneLightYear;
            Console.WriteLine("{0:e2}", earthToStar);
            Console.WriteLine("{0:e2}", centerOfGalaxy);
            Console.WriteLine("{0:e2}", diameterOfMilkyWay);
            Console.WriteLine("{0:e2}", earthToUniverse);

        }
    }
}
