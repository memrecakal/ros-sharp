/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Action
{
    public class CancelGoal_Request : Message
    {
        public const string RosMessageName = "action_msgs/msg/CancelGoal_Request";

        //  Cancel one or more goals with the following policy:
        // 
        //  - If the goal ID is zero and timestamp is zero, cancel all goals.
        //  - If the goal ID is zero and timestamp is not zero, cancel all goals accepted
        //    at or before the timestamp.
        //  - If the goal ID is not zero and timestamp is zero, cancel the goal with the
        //    given ID regardless of the time it was accepted.
        //  - If the goal ID is not zero and timestamp is not zero, cancel the goal with
        //    the given ID and all goals accepted at or before the timestamp.
        //  Goal info describing the goals to cancel, see above.
        public GoalInfo goal_info { get; set; }

        public CancelGoal_Request()
        {
            this.goal_info = new GoalInfo();
        }

        public CancelGoal_Request(GoalInfo goal_info)
        {
            this.goal_info = goal_info;
        }
    }
}
#endif