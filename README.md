# tennis-kata

### Overview

Create a C# Console App that can run a tennis game between two players. Focus on using TDD to detail the requirements and focus on testing the rules of the game. 

### Requirements

- Each player should start with a score of zero.
- The game should calculate a winner based on a coin flip.
- When a player wins a round their score increases.
- The game should be won by the first player to reach a score of at least 4 points and be ahead of their opponent by at least 2 points.
- If the game is tied at 3-3, it should be referred to as "deuce".
- If the game is in "deuce", a player must win two points in a row to win the game.
- When a player wins a point, their score should be updated accordingly (i.e., 0, 15, 30, 40, or "advantage" in the case of deuce).
- If a player has "advantage" and wins the next point, they win the game. If they lose the next point, the game returns to "deuce".
- The program should display the current score after each point is played.
