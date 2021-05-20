using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SLSettingData : MonoBehaviour
{
    public SettingsData SD;
    // Start is called before the first frame update
    void Awake()
    {
        LoadMD();
    }

    public void LoadMD()
    {
        if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/MGQHH/Saves/Main Setings.json"))
        {
            SD.MS = JsonUtility.FromJson<MainSettings>(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/MGQHH/Saves/Main Setings.json"));
        }
    }
    public void SaveMD()
    {
        if (!System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/MGQHH/Saves"))
        {
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/MGQHH/Saves");
        }
        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/MGQHH/Saves/Main Setings.json", JsonUtility.ToJson(SD.MS));
    }
}
