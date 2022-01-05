# Overcooked/platform

The goal is to correctly assemble products, that were ordered, by modifying a raw item on a correct workstation at the correct time. These workstations are scattered across the map along the product line, where the raw item travels. Path to these stations may not always me straight and the player has to jump/parkour their way to them. But he shall not be alone in this task, they will be joined by their trusty teammate to help them on the job.

## Controls

The controls should be simple:

- Movement (WSAD, joystick)
- Dash (shift, X)
- Jump (space, A)
- Action (E, Y)

The goal is to create a local coop so the supported inputs (combinations) should be:

- Two players sharing one keyboard (WSAD/arrow keys,...)
- Keyboard + controller
- 2 controllers

## Gameplay

Players should navigate through the factory avoiding obstacles and activationg worksations at correct times by jumping to them. Throughout the level players receive orders and must complete them. If the product is assembled correctly at the end of the line players are rewarded, punished otherwise.

### Obstacles

There should be a death mechanic in this game similar to the overcooked, punishing the player with 5s respawn, thus putting their teammate at a disadvantage. 

Ideas for obstacles:

- Spikes
- Fire/projectiles
- Void floor
- Ripped electric cables
- ...

### Workstations

Workstations are placed along the product line and can change **one** attribute of the final product if they are activated at the time the item is in their range (e.g. if were making robots, one WS can change the shape of the body to be triangle, other to be circle, another can modify the color of the robot, lets say to green and another one to black, so the players receive the order for black robot with circular body, a generic robot enters the product line and they have to activate correct WS when the robot is in their aoe)

Ideas for WS:

- WS is always active - to not effect the item they have to manually disable it for the entire duration when the item crosses its aoe
- WS can be connected (via cable) - player at the beginning of a round, or it can be predetermined, can connect two/more WS with cable to sync them. If one is active the other one is active as well
- WS can break during the round so player has to manually repair it (wait there for some amount of time)
- ...

## Co-op

Players should cooperate to win, some ideas for cooperation:

- Some distances are too high up, so one has to help the other by lifting/pushing/boosting them
- There can buttons to disable some obstacles that are blocking a WS, so one player has to push this button so the other can use the WS
- In some levels the players can be connected (rope or chain,...) so they cannot more far apart and have to move strategically
- ...
