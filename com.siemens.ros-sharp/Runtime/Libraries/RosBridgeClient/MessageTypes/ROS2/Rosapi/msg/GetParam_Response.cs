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
    public class GetParam_Response : Message
    {
        public const string RosMessageName = "rosapi_msgs/msg/GetParam_Response";

        public string @value { get; set; }

        public GetParam_Response()
        {
            this.@value = "";
        }

        public GetParam_Response(string @value)
        {
            this.@value = @value;
        }
    }
}
#endif
