using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckTheBar : MonoBehaviour
{
    bool parrot;
    Progress_Bar bar;
    public Image Parrot;

    private void Start()
    {
        if (GetComponent<Image>() == true)
        {
            //bar.AddPoint();
            Debug.Log("reeeeeeeeeeeee");
        }
    }
    private void Update()
    {
        if(parrot)
        {
            bar.AddPoint();
            parrot = false;
        }
    }
}
