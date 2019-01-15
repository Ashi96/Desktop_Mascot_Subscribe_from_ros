# Desktop_Mascot_Subscribe_from_ros
![Alt](https://github.com/Ashi96/Desktop_Mascot_Subscribe_from_ros/blob/master/docs/images/Desktop_Mascot_Subscribe_from_ros.JPG)
## Overview
Make Desktop Mascot and Subscribe message from ros with rosbridge
## Description
- Made mascot on the desktop (Desktop Mascot).  
- Subscribe message from ros  with rosbridge and display message on the Desktop.  
## Demo
(https://www.youtube.com/watch?v=8awjROK_xuI&feature=youtu.be)
## Requirement
- Computer  
  - AlienWare R13
- OS
  - Windows 10
  - Ubuntu 16.04 (VirtualBox)
- ROS
  - ROS kinetic kame
## Software
- Unity 2017.3.1f1 (64-bit)
- Character
  - unity-chan  (http://unity-chan.com/contents/guideline/)
## Usage
#### rosbridge
- Ubuntu 16.04
  - rosbridge_suite  (http://wiki.ros.org/rosbridge_suite)
#### Publisher
- Ubuntu 16.04
##### Install
- ros_publish_to_unity  (https://github.com/Ashi96/ros_publish_to_unity)
~~~
$ cd ~/catkin_ws/src
$ git clone https://github.com/Ashi96/ros_publish_to_unity.git
$ cd ../ && catkin_make
~~~
##### Publish
~~~
$ roscore
$ rosrun ros_publish_to_unity chat.py
ex) display "Hello World!!"
Hello World!!
~~~
#### Subscriber
- Windows 10
##### Install
~~~
$ git clone https://github.com/Ashi96/Desktop_Mascot_Subscribe_from_ros.git
~~~
##### Subscribe
- Build & Run
## License
- unity-chan  
![Alt](https://github.com/Ashi96/Desktop_Mascot_Subscribe_from_ros/blob/master/docs/images/imageLicenseLogo.png)
- MIT License  
This software is released under the MIT License, see LICENSE.txt.
