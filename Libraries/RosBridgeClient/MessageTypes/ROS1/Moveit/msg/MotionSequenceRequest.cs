/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class MotionSequenceRequest : Message
    {
        public const string RosMessageName = "moveit_msgs/MotionSequenceRequest";

        //  List of motion planning request with a blend_radius for each.
        //  In the response of the planner all of these will be executable as one sequence.
        public MotionSequenceItem[] items { get; set; }

        public MotionSequenceRequest()
        {
            this.items = new MotionSequenceItem[0];
        }

        public MotionSequenceRequest(MotionSequenceItem[] items)
        {
            this.items = items;
        }
    }
}
#endif
