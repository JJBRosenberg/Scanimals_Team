using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParentPage : MonoBehaviour
{
    private int keepUp;
    [SerializeField] private GameObject parentPanel;
    [SerializeField] private GameObject welcomePanel;
    [SerializeField] private GameObject mapPanel;
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
            parentPanel.transform.position = new Vector3(0.0f, -116.0f, 0.0f);
            panelPressed = true;
            Debug.Log("yeeeeeeeeeeeeeeeeeeeeeeeet");
        } else if (panelPressed)
        {
            parentPanel.transform.position = new Vector3(0.0f, -316.0f , 0.0f);
            panelPressed = false;
            Debug.Log("fuckkkkkkkkkkk");
        }
    }

    public void toMapPanel()
    {
        welcomePanel.gameObject.SetActive(false);
        mapPanel.gameObject.SetActive(true);
    }

    void Update()
    {

        if (droppy.value == 0)
        {
            imageChanger.sprite = location1;
            if (droppy.value != keepUp)
            {
                parentPanel.transform.position = new Vector3(-116.0f, 0.0f, 0.0f);
                droppy.value = keepUp;
            }
        }
        else if (droppy.value == 1)
        {
            imageChanger.sprite = location2;
            if (droppy.value != keepUp)
            {
                parentPanel.transform.position = new Vector3(-116.0f, 0.0f, 0.0f);
                droppy.value = keepUp;
            }
        }

        else if (droppy.value == 2)
        {
            imageChanger.sprite = location3;
            if (droppy.value != keepUp)
            {
                parentPanel.transform.position = new Vector3(-116.0f, 0.0f, 0.0f);
                droppy.value = keepUp;
            }
        }
         

    }
}
