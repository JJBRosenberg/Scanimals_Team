using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AnimalCamera : MonoBehaviour
{
    public static Dictionary<string, bool> checkList = new Dictionary<string, bool>()
    {
        {"Parrot", false },
        {"Bear", false },
        {"Zebra", false },
        {"Dolphin", false }
    };

    bool Parrots;
    public bool parrot;
    public bool bear;
    public bool zebra;
    public bool dolphin;
    string ScreenCapDirectory = "Assets//Resources//";
    public string ScreenCapName = "CoolPic";
    public string fileType = ".png";
    private int count;
    private int ScreenCaps;
    bool[] pictures = new bool[4];
    private KeyCode keyPress = KeyCode.F2;

    enum animals { PARROT, BEAR, ZEBRA, DOLPHIN}
    enum animalsProgress { PARROT, BEAR, ZEBRA, DOLPHIN }
    void Start()
    {
        loadData();
        
        count = 0;
        ScreenCaps = 0;
        //if (!checkList["Parrot"])
            //checkList.Add("Parrot", false);
        //checkList["Parrot"] = false;
    }
    
    int FindScreenCaptures(string DirectoryPath, string FileName)
    {
        //Set count to 0 at every run so we count up from 0 to 
        //how many files exist with the FileName entered
        count = 0;

        //This loops through the files in your entered Directory
        for (int i = 0; i < Directory.GetFiles(DirectoryPath).Length; i++)
        {
            //If any file has the same name as your picture
            if (Directory.GetFiles(DirectoryPath)[i].Contains(FileName))
            {
                //Add 1 to the count because we need to know how many
                //files with the same name exist
                count += 1;
            }
        }
        //Once we know we return that amount
        return count;
    }
    public void PickCamera(int value)
    {
        switch ((animals)value) {
            case animals.PARROT:
                ParrotCam();
                break;

            case animals.BEAR:
                BearCam();
                break;

            case animals.ZEBRA:
                ZebraCam();
                break;

            case animals.DOLPHIN:
                DolphinCam();
                break;

        }

    }

    int boolToInt(bool val)
    {
        if (val)
            return 1;
        else
            return 0;
    }

    bool intToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;
    }   
    public void ParrotCam()
    {
        parrot = true;
        Debug.Log(parrot);
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Parrot_Pictures" + fileType);
        PlayerPrefs.SetInt("Parrot", (parrot ? 1 : 0));
        //Parrot = true;
        //Parrot = (PlayerPrefs.GetInt("Parrot") != 0);
        Debug.Log(parrot);
    }
        public void BearCam()
    {
        bear = true;
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Bear_Pictures" + fileType);
        PlayerPrefs.SetInt("Bear", (bear ? 1 : 0));
    }
    public void ZebraCam()
    {
        zebra = true;
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Zebra_Pictures" + fileType);
        PlayerPrefs.SetInt("Zebra", (zebra ? 1 : 0));
    }

    public void DolphinCam()
    {
        dolphin = true;
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Dolphin_Pictures" + fileType);
        PlayerPrefs.SetInt("Dolphin", (dolphin ? 1 : 0));
    }

    private void Update()
    {
        //ScreenCaps = (FindScreenCaptures(ScreenCapDirectory, ScreenCapName));
        //loadData();
        //Debug.Log(Parrots);
        //Debug.Log(Parrot);
        //If we press our capture key

        if (Input.GetKeyDown(keyPress))
        {
            PlayerPrefs.SetInt("Parrot", 0);
            PlayerPrefs.SetInt("Bear", 0);
            PlayerPrefs.SetInt("Zebra", 0);
            PlayerPrefs.SetInt("Dolphin", 0);
            Debug.Log("Deleted Achivements");
        }

    }
    void loadData()
    {
        parrot = intToBool(PlayerPrefs.GetInt("Parrot"));
        bear = intToBool(PlayerPrefs.GetInt("Bear"));
        zebra = intToBool(PlayerPrefs.GetInt("Zebra"));
        dolphin = intToBool(PlayerPrefs.GetInt("Dolphin"));
    }
}
