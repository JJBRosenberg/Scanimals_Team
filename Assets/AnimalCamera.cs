using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalCamera : MonoBehaviour
{

    enum animals { PARROT, BEAR, ZEBRA, DOLPHIN}

    public void PickCamera(int value)
    {
        switch ((animals)value) {
            case animals.PARROT:
            ScreenCapture.CaptureScreenshot("Parrot_Pictures.png");
                break;

            case animals.BEAR:
                ScreenCapture.CaptureScreenshot("Bear_Pictures.png");
                break;

            case animals.ZEBRA:
                ScreenCapture.CaptureScreenshot("Zebra_Pictures.png");
                break;

            case animals.DOLPHIN:
                ScreenCapture.CaptureScreenshot("Dolphin_Pictures.png");
                break;

        }

    }
    public void ParrotCam()
    {
    }

    public void BearCam()
    {
        
    }
    public void ZebraCam()
    {
    }

    public void DolphinCam()
    {
    }
}
