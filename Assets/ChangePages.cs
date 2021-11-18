using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePages : MonoBehaviour
{
    [SerializeField] private GameObject TapToScanPage;
    [SerializeField] private GameObject ChildrenOrGuardianPage;


    public void TapToScanButton()
    {
        TapToScanPage.gameObject.SetActive(false);
        ChildrenOrGuardianPage.gameObject.SetActive(true);
    }
}
