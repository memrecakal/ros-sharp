/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.ActionTutorialsInterfaces
{
    public class FibonacciGoal : Message
    {
        public const string RosMessageName = "action_tutorials_interfaces/action/FibonacciGoal";

        public int order { get; set; }

        public FibonacciGoal()
        {
            this.order = 0;
        }

        public FibonacciGoal(int order)
        {
            this.order = order;
        }
    }
}
#endif
