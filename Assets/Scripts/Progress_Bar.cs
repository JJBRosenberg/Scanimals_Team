using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress_Bar : MonoBehaviour
{
    public int Maximum = 4;
    public int Current = 0;
    public Image Mask;
    private bool bear;
    private bool zebra;
    private bool parrot;
    private bool dolphin;
    int bar;
    // Start is called before the first frame update
    void Start()
    {

        parrot = GameObject.Find("CameraButtonActions").GetComponent<AnimalCamera>().parrot;
        bear = GameObject.Find("CameraButtonActions").GetComponent<AnimalCamera>().bear;
        zebra = GameObject.Find("CameraButtonActions").GetComponent<AnimalCamera>().zebra;
        dolphin = GameObject.Find("CameraButtonActions").GetComponent<AnimalCamera>().dolphin;
        //Debug.Log(parrot);
        if (parrot)
            Current++;

        if (bear)
            Current++;

        if (zebra)
            Current++;

        if (dolphin)
            Current++;

        Debug.Log(Current);
        GetCurrentFill();
    }

    public void AddPoint()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    void GetCurrentFill()
    {
        //Debug.Log(bar);
        float fillAmount = Current / (float)Maximum;
        Mask.fillAmount = fillAmount;
    }
}
