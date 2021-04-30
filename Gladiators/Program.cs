using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class Program
    {
        static List<Gladiator> ReadInput(string inputFileName)
        {
            List<Gladiator> gladiators = new List<Gladiator>();

            StreamReader reader = null;
            string[] tokens;

            try
            {
                reader = new StreamReader(inputFileName);
                while (!reader.EndOfStream)
                {
                    tokens = reader.ReadLine().Split(';');
                    switch (tokens.Length)
                    {
                        case 2:
                            gladiators.Add(new ChristianGladiator(
                                                            byte.Parse(tokens[0]),
                                                            ParseOrigin(tokens[1])
                                                            ));
                            break;
                        case 3:
                            gladiators.Add(new FightingGladiator(
                                                            byte.Parse(tokens[0]),
                                                            ParseOrigin(tokens[1]),
                                                            sbyte.Parse(tokens[2])
                                                            ));
                            break;
                        default:
                            throw new ArgumentException("A txt fájl sora nem megfelelő hosszú");
                    }
                }
            }
            // KÜLÖNBÖZŐ KIVÉTELEK KEZELÉSE!!!
            catch (Exception ex) when (
                ex is EndOfServiceException 
                || ex is IncorrectYearNumberException
                || ex is FightingSpiritException
            )
            {
                System.Console.WriteLine("Reading input was interrupted. {0}", ex.message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return gladiators;
        }

        static OriginType ParseOrigin(string originString)
        {
            OriginType result = (OriginType) Enum.Parse(typeof(OriginType), originString);
            return result;
        }

        static void Main(string[] args)
        {
            List<Gladiator> gladiators = ReadInput("gladiators.txt");

            // 15 DB. TÁMADÁS RANDOM GLADIÁTOROK KÖZÖTT
            int n = 15;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int indexOfAttacker = rnd.Next(gladiators.Count);
                int indexOfAttacked = null;
                while (!indexOfAttacked)
                {
                    int randomIndex = rnd.Next(gladiators.Count);
                    if (randomIndex != indexOfAttacker)
                    {
                        indexOfAttacked = randomIndex;
                    }
                }
                Gladiator attacker = gladiators[indexOfAttacker];
                Gladiator attacked = gladiators[indexOfAttacked];
                bool attackResult = attacker.Attack(attacked);

                System.Console.WriteLine("{0}. A támadás lezajlott: {1}", i + 1, attackResult);
            }

            // ÉLETBENMARADÁSI STATISZTIKA KIÍRÁSA

            int numberOfChristiansAlive = gladiators.Where(g => g is ChristianGladiator && g.IsAlive).ToList().Count;
            int numberOfFightersAlive = gladiators.Where(g => g is FightingGladiator && g.IsAlive).ToList().Count;
            System.Console.WriteLine("Fighting gladiators alive: {0} \nChristian gladiators alive: {1}", numberOfFightersAlive, numberOfChristiansAlive);

            Console.ReadKey();
        }
    }
}
