/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Nav
{
    public class SetMapResponse : Message
    {
        public const string RosMessageName = "nav_msgs/srv/SetMap";

        //  True if the map was successfully set, false otherwise.
        public bool success { get; set; }

        public SetMapResponse()
        {
            this.success = false;
        }

        public SetMapResponse(bool success)
        {
            this.success = success;
        }
    }
}
#endif
