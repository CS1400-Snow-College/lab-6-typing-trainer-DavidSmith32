﻿using System.Diagnostics;
Console.Clear();
Console.WriteLine("Type the shown phrase.");
Stopwatch stopwatch = new Stopwatch();
Console.Clear();

string[] phrases = new string[3];
phrases[0] = "Nerako sat in the light in the entrance to the T.A.R.D.I.S., looking up at the sky, The stars are beautiful, arent they? He turned to his left, where a second beam of light revealed a small Valisa. She walked over and sat down next to the man, purring as he scratched between her horns, the man continued, One day, Ill take you to see every one. And you know what? Nerako looks down at Valisa, who looks back up at him expectantly, One day, what you bring will save all of those stars. Valisa looks back up at the stars, wonder in her eyes, her mouth slightly open. The man chuckles as he says And I cant wait to see it.";
phrases[1] = "The light shone across the entire room. It showed an empty plain. It is where the mansion is, but its not there in the recording. Nerako was there, studying the area around where the mansion is now. Valisa was standing nearby. So why are we here? She asked This place is closer than the rest of the world to the other side. Nerako said, We can find more if we can replicate whats here on the other side. Valisa seemed confused, Is it not the same already? No. he said, Theres a mansion on the other side, the first home of the heroes. If were to find out what happens, were going to have to recreate it.";
phrases[2] = "The dragon, staring down at the lava, spoke, Tido, If youre watching this, then I have failed at my mission. My species and yours have both fallen into obscurity. Dont let it stay that way. I fight to keep our legacy going. If youre seeing this, then fight to bring our legacy back. And Valisa… his eyes closed as a single tear fell down, If I dont make it back, take good care of yourself, and of our dear daughter. Take care of her so she may live a happy life. Then he raised his head, the sadness replaced by determination as the orb absorbed into his armor and he roared out, You will not go any farther. You will never harm my family again. This ends here. The lava began to bubble as the roar of Mi-Knathos rang out.";

Random rand = new Random();
int random = rand.Next(0, 2);
Console.Write(phrases[random]);
Console.SetCursorPosition(0, 0);
stopwatch.Start();
int miss = 0;
for (int i = 0; i < phrases[random].Length; i++)
{
    var pressed = Console.ReadKey(true).KeyChar;
    if (pressed == phrases[random][i])
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(phrases[random][i]);
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(phrases[random][i]);
        Console.ForegroundColor = ConsoleColor.White;
        if (phrases[random][i] != Convert.ToChar("\n"))
        {
            miss++;
        }}}
stopwatch.Stop();
double time = stopwatch.ElapsedMilliseconds / 1000;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" ");
Console.WriteLine($"You missed {miss} of {phrases[random].Length} letters.");
int Word = phrases[random].Split().Length;
double wpm = Math.Round(Word / time * 60);

Console.WriteLine($"You typed {wpm} words per minute.");