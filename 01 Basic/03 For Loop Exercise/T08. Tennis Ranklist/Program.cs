using System;

namespace T08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
         
            const int WIN_POINTS_TOURNAMENT = 2000;
            const int FINALIST_POINTS_TOURNAMENT = 1200;
            const int SEMI_FINALIST_POINTS_TOURNAMET = 720;
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints= int.Parse(Console.ReadLine());
            int points = startingPoints;
            double wonTournaments = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string positionTournament = Console.ReadLine();
                if (positionTournament=="W")
                {
                    points += WIN_POINTS_TOURNAMENT;
                    wonTournaments++;
                }
                else if (positionTournament=="F")
                {
                    points += FINALIST_POINTS_TOURNAMENT;
                }
                else
                {
                    points += SEMI_FINALIST_POINTS_TOURNAMET;
                }
            }
            Console.WriteLine($"Final points: {points}");
            int averagePoints = (points - startingPoints)/tournaments;
            Console.WriteLine($"Average points: {averagePoints}");
            double percentWonTournaments = wonTournaments / tournaments * 100;
            Console.WriteLine($"{percentWonTournaments:f2}%");



        }
    }
}
