using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SettingsData : MonoBehaviour
{
    public MainSettings MS;
    public void Start()
    {
        
        MainSettings MS = new MainSettings();
        /*
        MS.Test = KeyCode.E;
        Debug.Log(JsonUtility.ToJson(MS));
        Debug.Log(JsonUtility.FromJson<MainSettings>(JsonUtility.ToJson(MS)).Test);
        */
    }
    public void SetMSValueSound(float i)
    {
        MS.Sound = i;
    }
    public void SetMSValueMusic(float i)
    {
        MS.Music = i;
    }
    public void SetMSValueTextskipping(float i)
    {
        MS.Textskipping = i;
    }
}

//Основные настройки
[System.Serializable]
public class MainSettings
{
    //Звук громкость
    public float Sound = 1;
    //Музыка громкость
    public float Music = 1;

    //Скорость пропуска
    public float Textskipping = 0.1f;

    //УПРАВЛЕНИЕ
    public KeyCode Up = KeyCode.W;
    public KeyCode Down = KeyCode.S;
    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;
}
