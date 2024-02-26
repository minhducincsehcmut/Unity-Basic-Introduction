using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;



public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public string adaUsername = "cdanh2012";
    public string adaKey = "aio_qoAD63f6qz4h0B8tAEouAafXt2qb";
    public string pub1 = "cdanh2012/feeds/airtemp";
    public string pub2 = "cdanh2012/feeds/light";
    public string sub1 = "cdanh2012/feeds/mqtt-subscribe";
    public string sub2 = "cdanh2012/feeds/mqtt-subscribe1";
    private MqttClient client;
    public mqttReceiver eventSender1;
    public mqttReceiver2 eventSender2;
    public mqttReceiver3 eventSender3;

    public TMP_InputField Data1, Data2;
    public Button sendData1, sendData2;
    void Start()
    {
        client = new MqttClient("io.adafruit.com");
        string clientId = "UnityClient_" + UnityEngine.Random.Range(0, 1000);
        client.Connect(clientId, adaUsername, adaKey);
        if (client != null&& client.IsConnected)
        {
            Debug.Log("Client is connected.");
        }
        else
        {
            Debug.LogError("Failed to connect to MQTT server.");
        }
        if (eventSender1 != null)
        {
            eventSender1.topicSubscribe = sub1;
            eventSender1.OnMessageArrived += OnMessageArrivedHandler1;
        }
        if (eventSender2 != null)
        {
            eventSender2.topicSubscribe = sub2;
            eventSender2.OnMessageArrived += OnMessageArrivedHandler2;
        }
        sendData1.onClick.AddListener(SendData1);
        sendData2.onClick.AddListener(SendData2);
    }
    private void OnMessageArrivedHandler1(string newMsg)
    {
        if (eventSender1 != null)
        {
            if (eventSender1.topicSubscribe == sub1)
            {
                Debug.Log("Message from feed1: " + newMsg);
            }
            else
            {
                Debug.LogWarning("Unknown message source: " + newMsg);
            }
        }
    }
    private void OnMessageArrivedHandler2(string newMsg)
    {
        if (eventSender2 != null)
        {
            if (eventSender2.topicSubscribe == sub2)
            {
                Debug.Log("Message from feed2: " + newMsg);
            }
            else
            {
                Debug.LogWarning("Unknown message source: " + newMsg);
            }
        }
    }
    public void SendData1() {
        string data = Data1.text;
        Debug.Log(data);
        if (client != null && client.IsConnected)
        {
            Debug.Log("HAHAH");
        }
        client.Publish(pub1, System.Text.Encoding.UTF8.GetBytes(data), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
    }
    public void SendData2()
    {
        string data = Data2.text;
        Debug.Log(data);
        client.Publish(pub2, System.Text.Encoding.UTF8.GetBytes(data), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
