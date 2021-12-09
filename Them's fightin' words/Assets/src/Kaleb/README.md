The Fighting Game

Overview:
This is the segment where the player fights against whatever NPC they initiated combat with. The game is based on standard 2D fighters, in the vein of Street Fighter 2. 

Entities:
	Player
	NPC
	Interface
	Background
	Pause Menu
	FGManager

Player:
The player is one of the two fighters. The player can move their character left and right and use three different attacks, each with different speeds and damage values.

NPC:
The NPC moves like the player, but depending on the character can have one to three attack moves.

Interface:
Each character has a life total, displayed at the top of the screen. The life total is reduced when hit by an opponent's attack.

Transitions:
When one entity's life reaches zero, the other wins the fighting game and the player is returned to the overworld. If the player presses the pause button, they will enter the battle pause menu, where they can view a systems tutorial, activate or deactive easy mode, or exit the game.
In DrBC mode, the player's life total being 0 does not cause a loss and their life bar does not update.

FG Manager:
This handles updating the interface and the pause menu, and manages the transitions from the scene.
