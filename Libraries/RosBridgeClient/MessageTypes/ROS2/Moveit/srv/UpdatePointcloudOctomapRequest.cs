/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.Sensor;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class UpdatePointcloudOctomapRequest : Message
    {
        public const string RosMessageName = "moveit_msgs/srv/UpdatePointcloudOctomap";

        public PointCloud2 cloud { get; set; }

        public UpdatePointcloudOctomapRequest()
        {
            this.cloud = new PointCloud2();
        }

        public UpdatePointcloudOctomapRequest(PointCloud2 cloud)
        {
            this.cloud = cloud;
        }
    }
}
#endif
