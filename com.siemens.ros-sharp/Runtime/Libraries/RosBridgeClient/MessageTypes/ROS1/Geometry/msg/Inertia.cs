/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class Inertia : Message
    {
        public const string RosMessageName = "geometry_msgs/Inertia";

        //  Mass [kg]
        public double m { get; set; }
        //  Center of mass [m]
        public Vector3 com { get; set; }
        //  Inertia Tensor [kg-m^2]
        //      | ixx ixy ixz |
        //  I = | ixy iyy iyz |
        //      | ixz iyz izz |
        public double ixx { get; set; }
        public double ixy { get; set; }
        public double ixz { get; set; }
        public double iyy { get; set; }
        public double iyz { get; set; }
        public double izz { get; set; }

        public Inertia()
        {
            this.m = 0.0;
            this.com = new Vector3();
            this.ixx = 0.0;
            this.ixy = 0.0;
            this.ixz = 0.0;
            this.iyy = 0.0;
            this.iyz = 0.0;
            this.izz = 0.0;
        }

        public Inertia(double m, Vector3 com, double ixx, double ixy, double ixz, double iyy, double iyz, double izz)
        {
            this.m = m;
            this.com = com;
            this.ixx = ixx;
            this.ixy = ixy;
            this.ixz = ixz;
            this.iyy = iyy;
            this.iyz = iyz;
            this.izz = izz;
        }
    }
}
#endif
