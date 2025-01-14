/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2
using RosSharp.RosBridgeClient.MessageTypes.Std;
namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class LocalPlannerActionFeedback : ActionFeedback<LocalPlannerFeedback>
    {
        public const string RosMessageName = "moveit_msgs/action/LocalPlannerActionFeedback";

        public LocalPlannerActionFeedback() : base()
        {
            this.values = new LocalPlannerFeedback();
        }

        public LocalPlannerActionFeedback(Header header, string id, string action, LocalPlannerFeedback values) : base(header, id, action)
        {
            this.values = values;
        }
    }
}
#endif
