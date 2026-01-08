using System.Text;

namespace MyApp;

public class Day2026_01_07
{
    void Task()
    {
            Console.OutputEncoding = Encoding.UTF8;
            const int sizeX = 20, sizeY = 20;
            int playerX = sizeX / 2, playerY = sizeY - 2;
            var foo = new List<(int, int)>();
            var rand = new Random();
            int fooRespawnMaxDeley = 10;
            int fooRespawnDeley = 20;
            int score = 0;
            while (true)
            {
                ++score;
                ++fooRespawnDeley;
                if ( fooRespawnMaxDeley<= fooRespawnDeley)
                {
                    fooRespawnDeley = 0;
                    if (3 <= fooRespawnMaxDeley)
                        --fooRespawnMaxDeley;
                    var count = rand.Next(1, 3);
                    for (int i = 0; i < count; ++i)
                    {
                        foo.Add((rand.Next(1, sizeX - 1), 1));
                    }
                }
                Console.Clear();
                for (int y = 0; y < sizeY; y++) 
                {
                    for (int x = 0; x < sizeX; x++)
                    {
                        if (y == 0 || y == sizeY - 1 || x == 0 || x == sizeX - 1)
                            Console.Write("\u2b1c".PadRight(2));
                        else if (playerX == x && playerY == y)
                            Console.Write("👷");
                        else
                        {
                            bool isFoo = false;
                            for (int i = 0; i < foo.Count; i++)
                            {
                                if (foo[i].Item1 == x && foo[i].Item2 == y)
                                {
                                    Console.Write("\ud83d\udca9");
                                    isFoo = true;
                                    break;
                                }
                            }

                            if (false == isFoo)
                                Console.Write('　');
                        }

                        if (y == 5 && x == sizeX - 1)
                            Console.Write($"     Score : {score}");
                    }
                    Console.WriteLine();
                }

                for (int i = foo.Count - 1; i >= 0; i--)
                {
                    if (foo[i].Item2 < sizeY)
                        foo[i] = (foo[i].Item1, foo[i].Item2 + 1);
                    else
                        foo.RemoveAt(i);
                }
                for (int i = foo.Count - 1; i >= 0; i--)
                {
                    if (foo[i].Item1 == playerX && foo[i].Item2 == playerY)
                        return;
                }

                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey(true);


                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (playerX > 1)
                                playerX--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (playerX < sizeX - 2)
                                playerX++;
                            break;
                    }
                }
                Thread.Sleep(100);
            }
    }
}