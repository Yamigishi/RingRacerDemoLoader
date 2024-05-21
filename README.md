# RingRacerDemoLoader
A simple software to load [Dr. Robotnik's Ring Racers](https://www.kartkrew.org/) demo files automatically within the right version of the game.

## How to use

Simply set the path to the Ring Racer .exe of the version(s) of the game you have in the corresponding box(es). The program will remember those if you close it, so you only have to set them up once. You **don't** have to set up every .exe, just the one(s) used for the replay files you have.

Then, simply drag and drop or select the replay file, and the program should read from it, detect which version of the game needs to be launched and launch it. If the version isn't supported it'll show you an error message, feel free to open an issue so I can update the program.

**Note that the program has no control over which exe you set, it just launches it. If you tell it to launch a file that's not an executable for the game, it'll still launch it.**

Additionally, you can add more [optional parameters](https://www.wiki.srb2.org/wiki/Command_line_parameters) using the text box set for that effect,if you want.
