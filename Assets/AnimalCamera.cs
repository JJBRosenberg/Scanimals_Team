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
    public bool Parrot;
    public bool Bear;
    string ScreenCapDirectory = "Assets//Resources//";
    public string ScreenCapName = "CoolPic";
    public string fileType = ".png";
    private int count;
    private int ScreenCaps;
    public KeyCode screenCaptureKey = KeyCode.F2;
    bool[] pictures = new bool[4];

    enum animals { PARROT, BEAR, ZEBRA, DOLPHIN}

    void Start()
    {
        loadData();
        Debug.Log(Parrot);
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
        Parrot = true;
        Debug.Log(Parrot);
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Parrot_Pictures" + fileType);
        PlayerPrefs.SetInt("Parrot", (Parrot ? 1 : 0));
        //Parrot = true;
        //Parrot = (PlayerPrefs.GetInt("Parrot") != 0);
        Debug.Log(Parrot);
    }
    void loadData()
    {
         Parrot = intToBool(PlayerPrefs.GetInt("Parrot"));
    }
        public void BearCam()
    {

        Debug.Log("aaaaaaaaaaaaaa");
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Bear_Pictures" + fileType);
    }
    public void ZebraCam()
    {
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Zebra_Pictures" + fileType);
    }

    public void DolphinCam()
    {
        ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Dolphin_Pictures" + fileType);
    }
    private void Update()
    {
        //ScreenCaps = (FindScreenCaptures(ScreenCapDirectory, ScreenCapName));
        //loadData();
        //Debug.Log(Parrots);
        //Debug.Log(Parrot);
        //If we press our capture key
        if (Input.GetKeyDown(screenCaptureKey))
        {
            //This is how you save the screenshot to a certain directory and a certain name
            //(ScreenCaps + 1): We reference this from above and use it for our picture name
            //                  So if we know 2 files exist we add 1 to our value so it is a new picture.
            //ScreenCapture.CaptureScreenshot(ScreenCapDirectory + ScreenCapName + (ScreenCaps + 1) + fileType);
            Debug.Log("ScreenCapture Taken!");
            //Debug.Log("ScreenCap Location: " + ScreenCapDirectory);
        }
    }
}
