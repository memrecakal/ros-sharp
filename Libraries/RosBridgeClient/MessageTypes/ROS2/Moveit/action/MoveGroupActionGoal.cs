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
    public class MoveGroupActionGoal : ActionGoal<MoveGroupGoal>
    {
        public const string RosMessageName = "moveit_msgs/action/MoveGroupActionGoal";

        public MoveGroupActionGoal() : base()
        {
            this.args = new MoveGroupGoal();
        }

        public MoveGroupActionGoal(Header header, GoalInfo goalInfo, MoveGroupGoal args) : base(header, goalInfo)
        {
            this.args = args;
        }
    }
}
#endif
