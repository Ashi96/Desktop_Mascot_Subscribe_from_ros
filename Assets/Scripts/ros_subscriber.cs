using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using WebSocketSharp.Net;
using UnityEngine.UI;

public class ros_subscriber : MonoBehaviour
{
    [System.Serializable]
    public class Ros
    {
        public string op;
        public string topic;
    }

    [System.Serializable]
    public class Ros_msgs
    {
        public string data;
    }

    [System.Serializable]
    public class Hello
    {
        public string op;
        public string topic;
        public Ros_msgs msg;
    }
    //[SerializeField] UnityEngine.UI.Text textbox;
    private Text targetText;
    private string a;
    // Use this for initialization
    void Start()
    {
        Ros_sub();
    }
    // Update is called once per frame
    void Update()
    {
        this.targetText = this.GetComponent<Text>();
        this.targetText.text = a;
    }

    void Ros_sub()
    {
        WebSocket ws;
        ws = new WebSocket("ws://192.168.22.131:9090/");    //PublishしているPCのIPアドレス

        ws.OnOpen += (sender, e) =>
        {
            Debug.Log("WebSocket Open");
            Ros data = new Ros();
            data.op = "subscribe";
            data.topic = "/chatter";
            string json = JsonUtility.ToJson(data);
            ws.Send(json);
        };
        ws.OnError += (sender, e) =>
        {
            Debug.Log("WebSocket Error Message: " + e.Message);
        };
        //JSON形式のデータがある時
        ws.OnMessage += (sender, e) =>
        {
            string message = e.Data;
            Debug.Log(message);

            Hello ros_data = JsonUtility.FromJson<Hello>(message);
            Debug.Log("Op name : " + ros_data.op);
            Debug.Log("Topic name : " + ros_data.topic);
            Debug.Log("Message : " + ros_data.msg.data);
            a = ros_data.msg.data;
            Debug.Log(a);
            //textbox.text = a;
        };
        ws.OnClose += (sender, e) =>
        {
            Debug.Log("WebSocket Close");
        };
        ws.Connect();
    }
}