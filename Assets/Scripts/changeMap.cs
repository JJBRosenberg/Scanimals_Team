using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeMap : MonoBehaviour
{
    [SerializeField] Image thisMap;
    [SerializeField] private Sprite maps;
    [SerializeField] private Sprite maps1;
    [SerializeField] private Sprite maps2;
    //[SerializeField] private RawImage maps1;
    //[SerializeField] private RawImage maps2;
    // Start is called before the first frame update
    public Dropdown myDrop;
    public void Update()
    {
        if (myDrop.value == 0)
        {
            thisMap.sprite = maps;
        }

        if (myDrop.value == 1)
        {
            thisMap.sprite = maps1;
        }

        if (myDrop.value == 2)
        {
            thisMap.sprite = maps2;
        }
    }
}
