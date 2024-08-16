/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.Actionlib
{
    public class TwoIntsActionFeedback : Message
    {
        public const string RosMessageName = "actionlib/TwoIntsActionFeedback";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public Header header { get; set; }
        public GoalStatus status { get; set; }
        public TwoIntsFeedback feedback { get; set; }

        public TwoIntsActionFeedback()
        {
            this.header = new Header();
            this.status = new GoalStatus();
            this.feedback = new TwoIntsFeedback();
        }

        public TwoIntsActionFeedback(Header header, GoalStatus status, TwoIntsFeedback feedback)
        {
            this.header = header;
            this.status = status;
            this.feedback = feedback;
        }
    }
}
#endif