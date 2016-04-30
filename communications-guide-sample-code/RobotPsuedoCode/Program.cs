using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPsuedoCode
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
/* 
The point of this program is provide some psuedocode that can be used to control the Modbots.
This sample code will ideally if run initialize two modbots,
one with controller and one without. Move them forward a certain distance
then have them spin in a circle. Then turn around, return to starting position
and then return to initial position it was facing.
 
(Initializing the robot)
addNewRobot(ip, port, modbot_id)
(this adds a new robot)

addNewRobotWithController(ip, port, modbot_id)
(Adds a new robot with controller)

initializSensorServer(sensor_server_name, port)
(this sets up the server to receive data from the modbots sensors
(use this if you want to use that data)

setMotorSpeeds(modbot_id, frontleft, frontright, backleft, backright)
(Sets the motor speeds for each of the modbots wheels. Values
(are from -255 to 255)

setMovementData(modbot_id, forward_v, strafe_v, rotate_v)
(Sets the movement of the modbot. Values are from -255 to 255
(This is a command that is used more than once. If you want to
(move the bot, set values, IF you want to stop the bot, set
(the values to 0.
( forward_v is forward/backward velocity of the modbot. Negative
(is backwards, positive forwards. strafe_v is strafing left or right
( positive is right, negative left. Rotate_ v is rotation. Positive 
(is clockwise, neg counterclockwise)

(we will now move the bot. For simplicity  the bots ID will be one)

setMovementData(1, V, 0, 0)
(Starts the bot going forwards)
wait(D/V)
(waits for a certain amount of time required to travel the distance
(we want)
setMovementData(1,0,0,0)
(Stops the modbot)
setMovementData(1,0,0,V)
(Sprins the modbot in a circle)
Wait((2piR)/V)
(Waits for the modbot to spin 1 full rotation)
setMovementData(1,0,0,0)
(stops modbot)
setMovementData(1,0,0,V)
(Sprins the modbot in a half circle)
Wait((piR)/V)
(Waits for the modbot to turn around)
setMovementData(1,0,0,0)
(stops modbot)
setMovementData(1, V, 0, 0)
(Starts the bot going forwards)
wait(D/V)
(waits for a certain amount of time required to travel the distance
(we want)
setMovementData(1,0,0,0)
(Stops the modbot)
 
    */
