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
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class OrientationConstraint : Message
    {
        public const string RosMessageName = "moveit_msgs/OrientationConstraint";

        //  This message contains the definition of an orientation constraint.
        public Header header { get; set; }
        //  The desired orientation of the robot link specified as a quaternion
        public Quaternion orientation { get; set; }
        //  The robot link this constraint refers to
        public string link_name { get; set; }
        //  Tolerance on the three vector components of the orientation error (optional)
        public double absolute_x_axis_tolerance { get; set; }
        public double absolute_y_axis_tolerance { get; set; }
        public double absolute_z_axis_tolerance { get; set; }
        //  Defines how the orientation error is calculated
        //  The error is compared to the tolerance defined above
        public byte parameterization { get; set; }
        //  The different options for the orientation error parameterization
        //  - Intrinsic xyz Euler angles (default value)
        public const byte XYZ_EULER_ANGLES = 0;
        //  - A rotation vector. This is similar to the angle-axis representation,
        //  but the magnitude of the vector represents the rotation angle.
        public const byte ROTATION_VECTOR = 1;
        //  A weighting factor for this constraint (denotes relative importance to other constraints. Closer to zero means less important)
        public double weight { get; set; }

        public OrientationConstraint()
        {
            this.header = new Header();
            this.orientation = new Quaternion();
            this.link_name = "";
            this.absolute_x_axis_tolerance = 0.0;
            this.absolute_y_axis_tolerance = 0.0;
            this.absolute_z_axis_tolerance = 0.0;
            this.parameterization = 0;
            this.weight = 0.0;
        }

        public OrientationConstraint(Header header, Quaternion orientation, string link_name, double absolute_x_axis_tolerance, double absolute_y_axis_tolerance, double absolute_z_axis_tolerance, byte parameterization, double weight)
        {
            this.header = header;
            this.orientation = orientation;
            this.link_name = link_name;
            this.absolute_x_axis_tolerance = absolute_x_axis_tolerance;
            this.absolute_y_axis_tolerance = absolute_y_axis_tolerance;
            this.absolute_z_axis_tolerance = absolute_z_axis_tolerance;
            this.parameterization = parameterization;
            this.weight = weight;
        }
    }
}
#endif
