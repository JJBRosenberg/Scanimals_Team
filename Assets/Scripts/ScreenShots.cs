using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShots : MonoBehaviour
{
    [SerializeField] private int maxAllowedScreenShots = 15;

    public string ScreenCapDirectory = "D:\\Unity\\Scanimals_Team\\Assets\\";
    private int pictureIndex;
    private int ScreenCaps;


    void Start()
    {
        ScreenCapDirectory = Application.persistentDataPath;
    }
    public void ScreenShot()
    {
        ScreenCapture.CaptureScreenshot("Animal_Pictures" + pictureIndex + ".png");
        pictureIndex++;
    }
}
