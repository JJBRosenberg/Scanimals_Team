using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AnimalCamera : MonoBehaviour
{

    //string ScreenCapDirectory = Application.persistentDataPath + "/" +  "D:\\Unity\\Scanimals_Team\\Assets.";
    public string ScreenCapName = "CoolPic";
    public string fileType = ".png";
    private int count;
    private int ScreenCaps;
    public KeyCode screenCaptureKey = KeyCode.F2;

    enum animals { PARROT, BEAR, ZEBRA, DOLPHIN}

    void Start()
    {
        count = 0;
        ScreenCaps = 0;

    }


    private void Update()
    {
        //ScreenCaps = (FindScreenCaptures(ScreenCapDirectory, ScreenCapName));

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
    public void ParrotCam()
    {
        /*
        var texture = new Texture2D(Screen.width, Screen.height);
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();

        // Save the screenshot as a PNG file.
        */
    }

    public void BearCam()
    {
        //ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Bear_Pictures" + fileType);
    }
    public void ZebraCam()
    {
        //ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Zebra_Pictures");
    }

    public void DolphinCam()
    {
        //ScreenCapture.CaptureScreenshot(ScreenCapDirectory + "Dolphin_Pictures");
    }
}
