using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParentPage : MonoBehaviour
{
    [SerializeField] private GameObject parentPanel;
    [SerializeField] private Image imageChanger;
    [SerializeField] private Sprite location1;
    [SerializeField] private Sprite location2;
    [SerializeField] private Sprite location3;
    private bool panelPressed;
    public Dropdown droppy;

    public void PanelPressed()
    {
        if (!panelPressed)
        {
            parentPanel.transform.position += new Vector3(200.0f, 0.0f, 0.0f);
            panelPressed = true;
        } else
        {
            parentPanel.transform.position -= new Vector3(200.0f, 0.0f, 0.0f);
            panelPressed = false;
        }
    }
    
    void Update()
    {
        
    }
    
}
