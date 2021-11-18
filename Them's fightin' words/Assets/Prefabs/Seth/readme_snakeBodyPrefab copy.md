# SnakeBody
## Variables
- snakeBodyPrefab: links to prefab of snakeBody
- SM: links to Snake Manager object
    - Needs to have GameOver function and AddScore function
- isTail: boolean, only true for last segment in body
- prevSegment: link to previous segment
- nextSegment: link to nextSegment
- Snake: Object that contains all the snake segments
- nextSegmentTailCode: links to the SnakeTail script of the nextSegment

## Methods
- void Start
  - Checks if the snake is the tail
- void AddSegment
  - Checks if tail, if not, call AddSegment on the next segment
  - When the tail is reached, instantiate a new snakeBodyPrefab
    - Update nextSegment and prevSegment fields
  - moveSegment
    - Transform self to prevSegment's last locations
    - If the tail hasn't been reached, call moveSegment on nextSegment
  - OnTriggerEnter2D
    - Check if the collision was with the snake's head or with a wall
      - if either, call GameOver in the Snake Manager.