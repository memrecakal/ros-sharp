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
    public class LocalPlannerAction : Action<LocalPlannerActionGoal, LocalPlannerActionResult, LocalPlannerActionFeedback, LocalPlannerGoal, LocalPlannerResult, LocalPlannerFeedback>
    {
        public const string RosMessageName = "moveit_msgs/action/LocalPlannerAction";

        public LocalPlannerAction() : base()
        {
            this.action_goal = new LocalPlannerActionGoal();
            this.action_result = new LocalPlannerActionResult();
            this.action_feedback = new LocalPlannerActionFeedback();
        }

    }
}
#endif
