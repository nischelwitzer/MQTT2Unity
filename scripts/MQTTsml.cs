/*
The MIT License (MIT)
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using M2MqttUnity;

// Examples for the M2MQTT library (https://github.com/eclipse/paho.mqtt.m2mqtt),

namespace M2MqttUnity.small
{

    public class MQTTsml : M2MqttUnityClient
    {

        private List<string> eventMessages = new List<string>();
        private int txCnt = 0;
        private int rxCnt = 0;

        protected override void Start()
        {
            Debug.Log("MQTT small is ready.");

            brokerPort = 1883;
            brokerAddress = "dmt.fh-joanneum.at";
            isEncrypted = false;
            autoConnect = true;

            InvokeRepeating("TestPublish", 5, 2);
            base.Start();
        }

        public void TestPublish()
        {
            string sendMsg = "TestMsg: " +(++txCnt);
            client.Publish("DMT/Show", System.Text.Encoding.UTF8.GetBytes(sendMsg), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            Debug.Log("Test message published");
        }

        protected override void SubscribeTopics()
        {
            client.Subscribe(new string[] { "DMT/Info" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }

        protected override void DecodeMessage(string topic, byte[] message)
        {
            
            string msg = System.Text.Encoding.UTF8.GetString(message);
            Debug.Log("MQTT Received: " + msg + " - "+ (++rxCnt));
        }

        private void OnDestroy()
        {
            Disconnect();
        }
        
    }
}
