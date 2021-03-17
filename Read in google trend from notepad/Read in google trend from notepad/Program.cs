using System;
using System.Collections.Generic;
using System.IO;

namespace Read_in_google_trend_from_notepad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap.csv");

            List<string> regions = new List<string>();
            List<double> soccerScores = new List<double>();
            List<double> footballScores = new List<double>();


            for (int i = 3; i < lines.Length; i++)
            {
                //North Dakota,12%,88%
                string line = lines[i];

                //     0            1           2
                //"North Dakota", "12%", and "88%"
                string[] pieces = line.Split(',');
                regions.Add(pieces[0]);

                // "12%"
                string soccerScoreAsString = pieces[1];
                double soccerScore = Convert.ToDouble(soccerScoreAsString.Trim('%')) / 100;
                soccerScores.Add(soccerScore);

                string footballScoreAsString = pieces[2];
                double footballScore = Convert.ToDouble(footballScoreAsString.Trim('%')) / 100;
                footballScores.Add(footballScore);  

            }
            for (int i = 0; i < footballScores.Count; i++)
            {
                if (soccerScores[i] > footballScores[i])
                {
                    Console.WriteLine(regions);
                }
            }
        }
    }
}
