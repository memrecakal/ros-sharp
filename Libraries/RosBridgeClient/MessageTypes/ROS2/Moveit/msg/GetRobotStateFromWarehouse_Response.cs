/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.Moveit;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class GetRobotStateFromWarehouse_Response : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/GetRobotStateFromWarehouse_Response";

        public RobotState state { get; set; }

        public GetRobotStateFromWarehouse_Response()
        {
            this.state = new RobotState();
        }

        public GetRobotStateFromWarehouse_Response(RobotState state)
        {
            this.state = state;
        }
    }
}
#endif
