using ExitGames.Client.Photon;
using UnityEngine;

public class ColorSerialization {
    public static byte[] SerializeColor(object targetObject) {  //직렬화 메서드
        Color color = (Color) targetObject;

        Quaternion colorToQuaterinon = new Quaternion(color.r, color.g, color.b, color.a);
        byte[] bytes = Protocol.Serialize(colorToQuaterinon);

        return bytes;
    }

    public static object DeserializeColor(byte[] bytes) { //역질렬화 메서드
        Quaternion quaterinon = (Quaternion) Protocol.Deserialize(bytes);

        Color color = new Color(quaterinon.x, quaterinon.y, quaterinon.z, quaterinon.w);

        return color;
    }
}