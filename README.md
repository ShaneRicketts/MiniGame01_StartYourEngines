[Check it out!](https://play.unity.com/mg/other/prototype01_build)

This project was part of the Unity Learn Pathway for Junior Programmers and has a couple things going on in it, with multiple scenes:

Scene 1 (Prototype 1)
- Has a vehicle being controlled via Script using Vertical Keys (Up, Down)  to move forward and Horizontal Keys (Left, Right) to rotate the vehicle left and right.
- Camera also follows player vehicle via script with an Offset also set via script
- Has basic setup with both the car and crates having rigidbodies to simulate collisions

Scene 2 (Challenge 1)
- Has a plane that flies forward similiarly to how the car does however I removed the ability to control the forward movement and made it fly forward on its own.
- Also rotates in a similar fashion to the car to change its forward movement direction.
- Unity's course released this with bugs to be fixed which included fixing the direction it was flying which was fixed via Script by changing Vector.back to vector3.forward
- The speed also needed fixed since it was going "Too fast". Originally it did not have it locked to a time based movement and instead was moving every frame which made it go incredibly quick so I used Time.deltaTime to fix it.
- Also made the camera follow the player via a script
- added a quick script to make the propeller on the front spin on the z axis

Scene 3 (Bonus Features 1)
- Took the first scene and made a copy of it
- made piles of obstacles to make them look nicer
- added Oncoming traffic to avoid that moves forward
- added a second vehicle and follow camera
- added a front veiw camera to swap between for both vehicles
- added code to swap veiws between cameras
- changed project setting to have two seperate controls for the vehicles via the Input Manager (First Car is Up Down Left Right while Second is W S A D)
- Changed the Veiwport Rect on all cameras to allow split screen
- added a public string to differentiate players and allow Local Multiplayer



Stuff I added on my own (Not Part of the Unity Lesson)

Start Menu Scene
- Added a Standard Menu Scene with functioning menu to select between the three scenes
- Added a Quit button to stop excecuting the game
- added a quit minigame button to return back to the start menu and added this to each minigame

Scene 1 & 3
- added a check in the code to check if a switch key was set for the cameras in case there werent any set in the player controller script
- added a script that makes objects destroy themselves if their position is less than -10 on the Y axis

All Scenes
-Added Sound Effects


