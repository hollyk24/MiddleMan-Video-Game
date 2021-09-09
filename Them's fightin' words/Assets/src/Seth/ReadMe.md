# Overworld Interaction & Movement

## Overview:

- Player Movement
  - Movement speed
- Player/World Collisions
- Z-Index
  - ie: walking over a sidewalk but under a tree
- Prompt to interact with objects or npcs
  - Initiating talking with someone
  - Prompt to pet a dog
  - Opening a door

---

### Player Movement

The player will move horizontally or vertically on a 2D grid, one unit at a
time.

---

### Player/World Collisions

The player will not be able to pass through some blocks, such as walls. This
will be accomplished using collision boxes.

---

### Scene Changes

When going into a new area, such as a door, the scene will change to a new area
to explore.

---

### Interacting with the World

Some objects in the world, such as doors, as well as npcs or animals will be
able to be interacted with via a pop-up prompt when the player is near them.
