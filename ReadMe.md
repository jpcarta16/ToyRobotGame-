# Toy Robot Game
This is a console application that simulates a toy robot moving on a square tabletop, with dimensions 5 units x 5 units.


## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.


### Prerequisites
.NET 5 SDK


### Installing
1. Clone the repository
    * git clone https://github.com/jpcarta16/ToyRobotGame-.git
2. Open a terminal window and navigate to the project directory.
3. Build the project
    * dotnet build
4. Run the project
    * dotnet run

### How to Play
The robot is free to roam around the surface of the table, but must be prevented from falling to destruction. Any movement that would result in the robot falling from the table must be prevented, however further valid movement commands must still be allowed.

### Commands
* **PLACE X,Y,FACING**: Place the robot on the table at X,Y and facing  NORTH, SOUTH, EAST or WEST.
* **MOVE**: Move the robot one unit forward in the direction it is currently facing.
* **LEFT**: Turn the robot 90 degrees to the left.
* **RIGHT**: Turn the robot 90 degrees to the right.
* **REPORT**: Show the current position and facing of the robot on the table.

### Running the Tests
The project includes unit tests for the Board and Robot classes.

To run the tests, navigate to the project directory in a terminal window and run the following command

* dotnet test
