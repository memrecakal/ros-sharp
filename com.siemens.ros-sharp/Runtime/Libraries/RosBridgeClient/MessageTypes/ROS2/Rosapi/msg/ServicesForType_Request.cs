/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class ServicesForType_Request : Message
    {
        public const string RosMessageName = "rosapi_msgs/msg/ServicesForType_Request";

        public string type { get; set; }

        public ServicesForType_Request()
        {
            this.type = "";
        }

        public ServicesForType_Request(string type)
        {
            this.type = type;
        }
    }
}
#endif
