using System;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            int setSize = 0;
            do
            {
                string input = Console.ReadLine();

                setSize = int.Parse(input);

                int totalElapsedTime = 0;
                int totalMiles = 0;
                for (int i = 0; i < setSize; i++)
                {
                    string logEntry = Console.ReadLine();
                    string[] logEntryParts = logEntry.Split(" ");
                    int miles = int.Parse(logEntryParts[0]);
                    int hours = int.Parse(logEntryParts[1]);
                    totalMiles += miles * (hours - totalElapsedTime);
                    totalElapsedTime = hours;
                }

                if (setSize != -1 && totalMiles > 0)
                {
                    Console.WriteLine(string.Format("{0} miles", totalMiles));
                }


            } while (setSize != -1);


        }
    }
}
