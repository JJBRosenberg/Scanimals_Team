using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckProgress : MonoBehaviour
{
    private static CheckProgress instance;

    enum animal { PARROT, BEAR, ZEBRA, DOLPHIN };
    public AnimalCamera stuff;
    public int pointCounter = 0;
    Image thisImage;
    private bool currentState;
    [SerializeField] int currentPicture;
    public bool parrot;
    public bool bear;
    public bool dolphin;
    public bool zebra;

    //public static CheckProgress Instance { get => instance; }
    private void Awake()
    {

    }

    private void Start()
    {

        parrot = GameObject.Find("CameraButtonActions").GetComponent<AnimalCamera>().parrot;
        bear = GameObject.Find("CameraButtonActions").GetComponent<AnimalCamera>().bear;
        zebra = GameObject.Find("CameraButtonActions").GetComponent<AnimalCamera>().zebra;
        dolphin = GameObject.Find("CameraButtonActions").GetComponent<AnimalCamera>().dolphin;
        //currentState = stuff.checAnimalProgress(currentPicture);
        thisImage = GetComponent<Image>();
        switch ((animal)currentPicture)
        {
            case animal.PARROT:
                parrotAchievemet();
                break;

            case animal.BEAR:
                bearAchievement();
                break;

            case animal.ZEBRA:
                zebraAchievement();
                break;

            case animal.DOLPHIN:
                dolphinAchievement();
                break;

        }


    }
    private void parrotAchievemet()
    {
        if (parrot)
        {
            thisImage.color = Color.green;
        }
        else
        {
            thisImage.color = Color.red;
        }
    }

    private void bearAchievement()
    {
        if (bear)
        {
            thisImage.color = Color.green;
        }
        else
        {
            thisImage.color = Color.red;
        }
    }

    private void zebraAchievement()
    {
        if (zebra)
        {
            thisImage.color = Color.green;
        }
        else
        {
            thisImage.color = Color.red;
        }
    }

    private void dolphinAchievement()
    {
        if (dolphin)
        {
            thisImage.color = Color.green;
        }
        else
        {
            thisImage.color = Color.red;
        }
    }

    private void Update()
    {
        Debug.Log(dolphin);

    }
}
