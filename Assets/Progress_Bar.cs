using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class Progress_Bar : MonoBehaviour
{
    public int Maximum;
    public int Current;
    public Image Mask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddPoint()
    {
        Current++;
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }
    void GetCurrentFill()
    {
        float fillAmount = (float)Current / (float)Maximum;
        Mask.fillAmount = fillAmount;
    }
}
