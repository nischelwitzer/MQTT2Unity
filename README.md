# MQTT2Unity - MQTT with Unity and C#

Base code:
```
Fork: https://github.com/nischelwitzer/M2MqttUnity
Original: https://github.com/gpvigano/M2MqttUnity
```

# MQTT Short Usage Example

https://github.com/nischelwitzer/MQTT2Unity/blob/main/scripts/MQTTsml.cs

```
public class MQTTsml : M2MqttUnityClient

protected override void Start()
brokerPort = 1883;
brokerAddress = "your server";   // for exampe dmt.fh-joanneum.at
mqttUserName  = "your_username";
mqttPassword  = "you passwort";
            
public void TestPublish()
```

# MQTT2Unity Working Sheet

Full 1 page example: [ab29_uduino_mqtt_move.pdf](https://github.com/nischelwitzer/MQTT2Unity/blob/main/pdf/ab29_uduino_mqtt_move.pdf)

# MQTT Video Tutorials (in german)

Video MQTT & Tasmota Einführung: https://youtu.be/Tc9gdXy4hJA

[![Video MQTT](https://img.youtube.com/vi/Tc9gdXy4hJA/0.jpg)](https://www.youtube.com/watch?v=Tc9gdXy4hJA)

Video MQTT in Unity: https://youtu.be/Qn8lByEU_4A

[![Video MQTT](https://img.youtube.com/vi/Qn8lByEU_4A/0.jpg)](https://www.youtube.com/watch?v=Qn8lByEU_4A)
