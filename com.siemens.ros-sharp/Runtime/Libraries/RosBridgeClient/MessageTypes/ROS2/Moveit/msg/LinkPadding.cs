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
    public class LinkPadding : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/LinkPadding";

        // name for the link
        public string link_name { get; set; }
        //  padding to apply to the link
        public double padding { get; set; }

        public LinkPadding()
        {
            this.link_name = "";
            this.padding = 0.0;
        }

        public LinkPadding(string link_name, double padding)
        {
            this.link_name = link_name;
            this.padding = padding;
        }
    }
}
#endif
