﻿/*
© Siemens AG, 2017-2018
Author: Dr. Martin Bischoff (martin.bischoff@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

// Added preprocessor directive flags for ROS2 support
// Siemens AG , 2024, Mehmet Emre Cakal (emre.cakal@siemens.com / m.emrecakal@gmail.com) 

using System;
using RosSharp.RosBridgeClient;
using std_msgs = RosSharp.RosBridgeClient.MessageTypes.Std;
using std_srvs = RosSharp.RosBridgeClient.MessageTypes.Std;
using rosapi = RosSharp.RosBridgeClient.MessageTypes.Rosapi;
using sensor_msgs = RosSharp.RosBridgeClient.MessageTypes.Sensor;
using System.Linq;

// on ROS2 system:
// launch before starting:
// ros2 launch rosbridge_server rosbridge_websocket_launch.xml
// ros2 topic echo /publication_test
// ros2 topic pub --once /subscription_test std_msgs/msg/String "data: 'subscription test message data'"

// launch after starting:
// ros2 service call /service_response_test <service_type> <request_data>

// on ROS1 system:
// launch before starting:
// roslaunch rosbridge_server rosbridge_websocket.launch
// rostopic echo /publication_test
// rostopic pub /subscription_test std_msgs/String "subscription test message data"

// launch after starting:
// rosservice call /service_response_test

namespace RosSharp.RosBridgeClientTest
{
    public class RosSocketConsoleTestProtocol
    {
        static readonly string uri = "ws://localhost:9090";

        public static void Main(string[] args)
        {
            //RosSocket rosSocket = new RosSocket(new RosBridgeClient.Protocols.WebSocketSharpProtocol(uri));
            RosSocket rosSocket = new RosSocket(new RosBridgeClient.Protocols.WebSocketNetProtocol(uri));

            // Publication:
            int ImageDataSize = 100;
            sensor_msgs.CompressedImage image = new sensor_msgs.CompressedImage();
            image.header.frame_id = "Test";
            string publication_id = rosSocket.Advertise<sensor_msgs.CompressedImage>("/test_image");

            Console.WriteLine("Press any key to start publication...");
            Console.ReadKey(true);
            for (int i = 0; i < 100000; i++)
            {
#if !ROS2
                image.header.seq += 1;
#endif
                image.data = Enumerable.Repeat((byte)0x20, ImageDataSize).ToArray();
                rosSocket.Publish(publication_id, image);
            }

            Console.WriteLine("Press any key to close...");
            Console.ReadKey(true);
            rosSocket.Unadvertise(publication_id);
            rosSocket.Close();
        }
        private static void SubscriptionHandler(std_msgs.String message)
        {
            Console.WriteLine((message).data);
        }

        private static void ServiceCallHandler(rosapi.GetParamResponse message)
        {
            Console.WriteLine("ROS distro: " + message.value);
        }

        private static bool ServiceResponseHandler(std_srvs.TriggerRequest arguments, out std_srvs.TriggerResponse result)
        {
            result = new std_srvs.TriggerResponse(true, "service response message");
            return true;
        }
    }
}