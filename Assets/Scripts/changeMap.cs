using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeMap : MonoBehaviour
{
    [SerializeField] RawImage thisMap;
    [SerializeField] private Texture maps;
    [SerializeField] private Texture maps1;
    [SerializeField] private Texture maps2;
    //[SerializeField] private RawImage maps1;
    //[SerializeField] private RawImage maps2;
    // Start is called before the first frame update
    public TMPro.TMP_Dropdown myDrop;
    public void Update()
    {
        if (myDrop.value == 0)
        {
            thisMap.texture = maps;
        }

        if (myDrop.value == 1)
        {
            thisMap.texture = maps1;
        }

        if (myDrop.value == 2)
        {
            thisMap.texture = maps2;
        }
    }
}
