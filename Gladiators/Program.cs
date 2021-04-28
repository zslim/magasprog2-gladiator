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
/*                            gladiators.Add(new ChristianGladiator(
                                                            byte.Parse(tokens[0]),
                                                            ???.Parse(tokens[1])
                                                            ));*/
                            break;
                        case 3:
/*                            gladiators.Add(new FightingGladiator(
                                                            byte.Parse(tokens[0]),
                                                            ???.Parse(tokens[1]),
                                                            byte.Parse(tokens[2])
                                                            ));*/
                            break;
                        default:
                            throw new ArgumentException("A txt fájl sora nem megfelelő hosszú");
                    }
                }
            }
            // KÜLÖNBÖZŐ KIVÉTELEK KEZELÉSE!!!
            catch
            {

            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return gladiators;
        }

        static void Main(string[] args)
        {
            List<Gladiator> gladiators = ReadInput("gladiators.txt");

            // 15 DB. TÁMADÁS RANDOM GLADIÁTOROK KÖZÖTT

            // ÉLETBENMARADÁSI STATISZTIKA KIÍRÁSA

            Console.ReadKey();
        }
    }
}
