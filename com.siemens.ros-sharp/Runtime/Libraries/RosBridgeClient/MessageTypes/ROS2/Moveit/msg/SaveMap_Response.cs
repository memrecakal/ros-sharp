/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class SaveMap_Response : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/SaveMap_Response";

        public bool success { get; set; }

        public SaveMap_Response()
        {
            this.success = false;
        }

        public SaveMap_Response(bool success)
        {
            this.success = success;
        }
    }
}
#endif
