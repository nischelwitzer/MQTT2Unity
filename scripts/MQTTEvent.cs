using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uPLibrary.Networking.M2Mqtt.Messages;
using M2MqttUnity;
using System;
using UnityEngine.Events;

[Serializable]
public class MQTTEventGot : UnityEvent<string> { }

public class MQTTEvent : M2MqttUnityClient
{
    private M2MqttUnityClient mqtt;
    public MQTTEventGot passMQTTEventData;

    protected override void Start()
    {
        brokerAddress = "dmt.fh-joanneum.at";
        mqttUserName = "dmt";
        mqttPassword = "xxxxxx;
        isEncrypted = false;
        autoConnect = true;
        base.Start();
    }

    protected override void Awake()
    {
        base.Awake();
    }

    // ###############################################################################################

    protected override void SubscribeTopics()
    {
        client.Subscribe(new string[] { "uduino/analogX" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
    }

    public void SendMQTT(string myString)
    {
        MQTTPublish("uduino/analogX", myString);
    }

    // ###############################################################################################
    // ###############################################################################################

    protected override void DecodeMessage(string topic, byte[] message)
    {
        string msg = System.Text.Encoding.UTF8.GetString(message);
        if (topic == "uduino/analogX")
        {
            passMQTTEventData.Invoke(msg);
        }
    }
}
