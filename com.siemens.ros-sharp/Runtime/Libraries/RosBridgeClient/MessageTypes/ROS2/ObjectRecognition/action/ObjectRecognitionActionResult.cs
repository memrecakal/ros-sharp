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

namespace RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition
{
    public class ObjectRecognitionActionResult : ActionResult<ObjectRecognitionResult>
    {
        public const string RosMessageName = "object_recognition_msgs/action/ObjectRecognitionActionResult";

        public ObjectRecognitionActionResult() : base()
        {
            this.values = new ObjectRecognitionResult();
        }

        public ObjectRecognitionActionResult(Header header, string action, sbyte status, bool result, string id, ObjectRecognitionResult values) : base(header, action, status, result, id)
        {
            this.values = values;
        }
    }
}
#endif
