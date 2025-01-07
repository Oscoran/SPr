/* 13 *6 stenne kostky
 * krava, lidi, clovek, ufo, tank!
 */

using martian_dice;


Gamemaster gamemaster = new Gamemaster();
gamemaster.gamestart();
Console.WriteLine();
while (gamemaster.Gameover())
{
    gamemaster.turnofplayer();
    Console.WriteLine();
}
for (int i = 0;i < gamemaster.Gamefinisher(); i++)
{
    gamemaster.turnofplayer();
    Console.WriteLine();
}
Console.WriteLine(Convert.ToString(gamemaster.Winner));


