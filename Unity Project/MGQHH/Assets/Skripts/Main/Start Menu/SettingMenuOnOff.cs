using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMenuOnOff : MonoBehaviour
{
    public SLSettingData SLD;
    public GameObject MainMenu;
    public GameObject SettingMenu;
    public void SettingOn()
    {
        MainMenu.SetActive(false);
        SettingMenu.SetActive(true);
        SaveMainData();
    }
    public void SettingOff()
    {
        MainMenu.SetActive(true);
        SettingMenu.SetActive(false);
        SaveMainData();
    }

    public void SaveMainData()
    {
        SLD.SaveMD();
    }
}
