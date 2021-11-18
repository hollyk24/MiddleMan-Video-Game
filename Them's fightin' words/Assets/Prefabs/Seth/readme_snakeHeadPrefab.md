# SnakeHead
## Variables
- SM: links to Snake Manager object
    - Needs to have GameOver function and AddScore function
- controls: links to Input System controls
- tailCode: The snake head is also a snakeBody object, so this links to the snakeBody script
- tailCodeNext: links to snakeBody code of next segment of code
- SnakeTailQueue: tells the SM how many segments need added
- Direction: 0 = Up, 1 = Down, 2 = Left, 3 = Right
- PrevDir: Same as Direction, but stores the last direction moved, so the snake can't reverse into itself
- InputAction: list of input actions from the Input Sytem

## Methods
- void Start
  - Enable controls
  - Find the SnakeManager
  - Find the tailCode and set tailCode.lastposition
  - Find tailCode of next segment
  - Start the movementListener loop
- onDestroy
  - Unsubscribe movement functions
- faceUp/Down/Left/Right
  - Sets the Direction variable to the associated direction
- moveSnake
  - Moves the head one unit in the direction specified
- movementListener
  - Until the game is over, loop:
    - Set the tailCode lastPostion to the current locations
    - run the moveSnake function on the Head
    - run moveSegment on the next segment, which will then call it on the next until hitting the tail
  - addSnakeSegment
    - calls AddSegment from the snakeBody code