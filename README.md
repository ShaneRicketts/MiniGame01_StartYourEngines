add playable link here later - TODO
This project was part of the Unity Learn Pathway for Junior Programmers and has a couple things going on in it, with multiple scenes:

#Scene 1 (Prototype 1)
- Has a vehicle being controlled via Script using Vertical Keys (Up, Down)  to move forward and Horizontal Keys (Left, Right) to rotate the vehicle left and right.
- Camera also follows player vehicle via script with an Offset also set via script
- Has basic setup with both the car and crates having rigidbodies to simulate collisions

#Scene 2 (Challenge 1)
- Has a plane that flies forward similiarly to how the car does however I removed the ability to control the forward movement and made it fly forward on its own.
- Also rotates in a similar fashion to the car to change its forward movement direction.
- Unity's course released this with bugs to be fixed which included fixing the direction it was flying which was fixed via Script by changing Vector.back to vector3.forward
- The speed also needed fixed since it was going "Too fast". Originally it did not have it locked to a time based movement and instead was moving every frame which made it go incredibly quick so I used Time.deltaTime to fix.
