using System;

namespace TreeehouseDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8,5);
            try 
            {
                Path path = new Path(
                    new[]
                    {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map),
                    }
                    );

                Console.WriteLine(map.DisplayMap(path, map));
                Console.WriteLine("\nAbove is the map. P denotes the path the invaders take. M denotes a space you can put a Tower");

                IInvader[] invaders =
                {
                    new BasicInvader(path),
                    new BasicInvader(path),
                    new BasicInvader(path),
                    new BasicInvader(path)
                };

                Console.WriteLine("\nYou can choose where to put your towers.");

                Tower[] towers = 
                {
                    new Tower(new MapLocation(0, 0, map)),
                    new Tower(new MapLocation(0, 0, map)),
                    new Tower(new MapLocation(0, 0, map)),
                    new Tower(new MapLocation(0, 0, map))
                };

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("\nValues for tower " + (i + 1));
                    Console.WriteLine("\nEnter an X value: ");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter a Y value: ");
                    int y = Int32.Parse(Console.ReadLine());
                    towers[i] = new Tower(
                        new MapLocation(x, y, map)
                        );
                    Console.WriteLine("Tower created at point ("+x+","+y+")");
                }


                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();
                Console.WriteLine("Player " + (playerWon? "won!" : "lost!"));

            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled Treehouse Defense Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled exception" + ex);
            }

        }
    }
}
