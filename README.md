# Astromech
A small program that enables voice control functionality to the game Star Wars: Squadrons.

# Feeling Generous?

https://paypal.me/BLINDRane?locale.x=en_US

# Dislaimer

I have tested this software on my own machine, and it has not hurt it. The program can use between 30 and roughly 60 MB of RAM at a time. For most machines, this should not cause any issues. However, if you happen to BARELY be able to run Squadrons, maybe don't use this?

I am not a verified publisher. Decide for yourself if you are ok with that. I am just a hobbyist. 

No, this is not malware. I am just telling you that odd behavior could occur that I did not experience in testing. 

In short, use at your own risk. 

# How to Install

Download the latest release in one of a few formats.

You should just be able to get "AstromechInstaller.msi" and run that. It is likely your computer will warn you that this could be dangerous (because I am not a verified publisher). Press "more info" and then "run anyway" and you are off.

If that does not work, grab the "AstromechInstallerCombo.zip" file. Simply unzip this folder and run setup.exe from inside it.

Either way, you will get Astromech installed in the folder of your choice, a shortcut on your desktop, and a shortcut in your program files. 

# How to Update or Uninstall

When updating to a newer version, there are two options. If you download the new release and install it to the same place as the old one, it should overwrite the old version and you should be good to go. Start Astromech and check the version number in the lower right (version 1 did not have a version number tag) If you want to be *absolutely sure* you could just use the next step.

The second option when updating is to uninstall Astromech using the windows uninstaller, and then just install the new version. No worries about overwrites here. 

To uninstall Astromech, simply use the built in windows uninstaller. 

NOTE: If you have made changes to the Commands.txt file, installing a new version of Astromech will overwrite your changes. If you want to keep them, save your changes somewhere. If I add more commands in the future, this note will change, because you will need to overwrite the file or risk breaking the program. For now though, this note is still relevant. 

# How to Use
Want to watch a video instead of reading a text wall? Try this! 
https://youtu.be/ChtjlNNp9Y4

Once this is installed, you can just run it from the shortcut on your desktop, or however you choose. 
A window will pop up. There are three options. 

First, decide if you want to use a wake-word. By default, Astromech works a lot like a smart speaker (Except no sharing of your data to the cloud here! This is all processed locally). The wake word is your droid name, which is "R 2" by default. If you would rather simply have voice commands, uncheck the box, and commands will be constantly listened for. 

Next, decide how long you want to listen for commands after the wake word is heard. By default, this is 10 seconds. You can go up to 100 seconds, though honestly if you do that just turn off the wake word. The timer will reset any time any command is given, so once you wake up your droid, it will listen to any commands you give it until there are 10 seconds of silence. 

Finally, name your droid. The default is "R 2" but you can use anything you want, just no symbols. If you have a hard time waking up your droid, I would try spelling the name phonetically. 

Once you have got your settings to your liking, press start. This will activate your Astromech, and also save your settings so that they come right up the next time you play. 

If you haven't booted Squadrons already, do it now. I also recommend using a good microphone. The speech recognizer requires solid audio to work well. 

Next, you need to set up some keybinds. This instruction assumes you are using MY defaults. For the most part, you will just need default keyboard bindings. The only thing you need to add is to bind "Focus Shields Front" and "Convert Power Engines" to 9 (NOT NUMPAD 9), "Focus Shields Rear" and "Convert Power Weapons" to 0 (NOT NUMPAD 0), and finally "Focus Shields Balanced" and "Convert Power Balanced" to - (NOT NUMPAD -).  

NOTE: Version 2.0 (and above) support custom keybinds. All keys are prefixed by "DIK_" followed by what the key is. Note that "DIK_9" and "DIK_NUM9" are different keys. The former is above the keyboard, while the latter is actually on the numpad. 

When in game, commands will only work properly while flying. However, since the commands work by simulating key presses, you could accidentally press some buttons (hence the wake word) When you get flying, simply say your droid's name to wake it up. You should hear a sound on awake, as well as a sound when the droid goes back to sleep. If you have disabled the wake word, you will be able to just say commands, instead. 

So what can your droid do? Well, there are 42 total commands. Two for each action. Here is the list, and what each item does: 

```
fire counter measures  //deploy counter measures
deploy counter measures 
full power to weapons //give all power to weapons
give me weapons 
full power to engines //give all power to engines
give me engines
full power to shields //give all power to shields
give me shields
balance power //balance power
balance me out
forward deflectors //focus shields to the front
forward shields
emergency power to engines //emergency power to engines
boost engines
rear deflectors //focus sheilds to the rear
rear shields
emergency power to weapons //emergency power to weapons
boost weapons
balance deflectors //balance shields
balance shields
balance emergency power //balance emergency power
normalize emergency power
lock on to him //target the person attacking you
target attacker
find me a target //cycle targets
cycle targets
target friendlies //target your squadron
show me friendlies
target hostiles //target enemy squadron
show me hostiles
target weak points //target weakpoints on capital ships (note that you have to be locked on for this to work. Otherwise, Steam will take a screenshot (whoops)
show me their weak points 
target fodder     //target AI opponenets
show me the fodder
target his tail   //target the attacker of currently locked ship, for helping allies
lets help him out
target their missiles //lock on to available missiles to shoot down. Useful for defending your capital ships
show me their missiles
light him up      //paints a target for your allies to focus on
paint that target
i see it        //acknowledge a painted target
acknowledge
```
So why so many different commands? Well, I wanted to give you options. Additionally, I wrote the code such that you can write in *anything you want* and it should work. 
Just go to the Commands.txt file (make a copy just in case), which can be found inside of your install folder, and edit away! There are some caveats though.

The code works with EXACTLY 42 commands and their __*purpose*__ must be in the EXACT order that I have them listed. They must also all be on __*separate lines*__. You can therefore have up to two custom commands per control, but you must always have 42 commands, you cannot have less than that, and you cannot have more. Doing so will result in crashing the program and odd behavior, respectively. Commands should also all be lowercase. A safe edit would be something like this: 
```
full power to weapons //give all power to weapons
lets blast them <----- changed this line from "give me weapons"
```
Finally, with all of that out of the way, play the game, and just issue commands while you fly to get an even more immersive experience, or just to keep from having to move your hands so much. 
