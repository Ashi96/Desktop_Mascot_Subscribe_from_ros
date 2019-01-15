# Desktop_Mascot_Subscribe_from_ros
### Overview
Make Desktop Mascot and Subscribe message from ros with rosbridge
### Description
- Made mascot on the desktop (Desktop Mascot).  
- Subscribe message from ros  with rosbridge and display message on the Desktop.  
### Demo
### Requirement
- Computer  
  - AlienWare R13
- OS
  - Windows 10
  - Ubuntu 16.04 (VirtualBox)
- ROS
  - ROS kinetic kame
### Software
- Unity 2017.3.1f1 (64-bit)
- Character
  - unity-chan  (http://unity-chan.com/contents/guideline/)
### Usage
#### rosbridge
  - rosbridge_suite  (http://wiki.ros.org/rosbridge_suite)
#### Publisher 
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
~~~
#### Subscriber
##### Install

### License
- unity-chan
  - © Unity Technologies Japan/UCL
