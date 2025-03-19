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

Video MQTT in Unity: https://youtu.be/Qn8lByEU_4A

<video width="320" height="240" controls>
  <source src="[video.mov](https://www.youtube.com/embed/Tc9gdXy4hJA?si=fsZtSiF905-Y__Uc&amp;controls=0)" type="video/mp4">
</video>
