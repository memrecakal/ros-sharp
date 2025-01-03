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
using RosSharp.RosBridgeClient.MessageTypes.Action;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class GlobalPlannerActionResult : ActionResult<GlobalPlannerResult>
    {
        public const string RosMessageName = "moveit_msgs/action/GlobalPlannerActionResult";

        public GlobalPlannerActionResult() : base()
        {
            this.values = new GlobalPlannerResult();
        }

        public GlobalPlannerActionResult(Header header, string action, sbyte status, bool result, string id, GlobalPlannerResult values) : base(header, action, status, result, id)
        {
            this.values = values;
        }
    }
}
#endif
