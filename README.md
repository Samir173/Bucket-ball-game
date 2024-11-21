# Bucket-ball-game
The project here is to build a 2D physics-based game in Unity. Players control a bucket to catch falling balls spawned at 3 random points. If the player misses too many balls, the game ends, otherwise move to next level or passed.
I have built a menu page, level 1, levle2, and passed page and fail page

The feature that was implemented in the code was to control the bucket’s horizontal movement while don’t move out of the game screen. The ball will spawn randomly from 3 spawn points. If the ball got into the bucket, it will be destroyed and the score value will increase, if the ball touch the bottom ground, ball will be destroy and the missed value will increase, for each level the miss value is reduce to match the idea of increase difficulty.
For the scripts.
Ball manager: handles ball’s spawning behavior.
BucketManager and Bucket control: handling detection of the ball got into the bucket and the movement the player had on the bucket.
GroundManager: If the ball touch the ground, update the Game Manager to update the missed value.
Game Manager: Keep track of the over Game stats and logic
