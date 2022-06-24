using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{

    public static SaveManager instance { get; private set; }

    //What to save
    public int checkpoints;

    public bool BGM = true;
    public bool SFX = true;


    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(gameObject);
        Load();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData_Storage data = (PlayerData_Storage)bf.Deserialize(file);

            checkpoints = data.checkpoints;
            BGM = data.BGM;
            SFX = data.SFX;

            file.Close();
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        PlayerData_Storage data = new PlayerData_Storage();

        data.checkpoints = checkpoints;
        data.BGM = BGM;
        data.SFX = SFX;

        bf.Serialize(file, data);
        file.Close();
    }

}

[Serializable]
class PlayerData_Storage
{
    public int checkpoints;
    public bool BGM;
    public bool SFX;
}
