using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShots : MonoBehaviour
{
    [SerializeField] private int maxAllowedScreenShots = 15;

    private int pictureIndex;

    public void ScreenShot()
    {
        ScreenCapture.CaptureScreenshot("Animal_Pictures" + pictureIndex + ".png");
        pictureIndex++;
    }
}
