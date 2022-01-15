using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{

    
    public static void SavePlayer(GameManager player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static void SavePlayer2(GameManager player2)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player2.fun";
        FileStream stream = new FileStream(path, FileMode.Create);
        

        PlayerData data = new PlayerData(player2);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static void SavePlayer3(GameManager player3)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player3.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player3);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;

        }else
        {
            Debug.LogError("Save File not found in" + path);
            return null;
        }
    }

    public static PlayerData LoadPlayer2()
    {
        string path = Application.persistentDataPath + "/player2.fun";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;

        }else
        {
            Debug.LogError("Save File not found in" + path);
            return null;
        }
    }

    public static PlayerData LoadPlayer3()
    {
        string path = Application.persistentDataPath + "/player3.fun";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;

        }else
        {
            Debug.LogError("Save File not found in" + path);
            return null;
        }
    }
}
