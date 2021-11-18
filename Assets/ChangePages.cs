using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePages : MonoBehaviour
{
    [SerializeField] private GameObject TapToScanPage;
    [SerializeField] private GameObject ChildrenOrGuardianPage;
    [SerializeField] private GameObject ChildrenPage;
    [SerializeField] private GameObject GuardianPage;
    [SerializeField] private GameObject firstInfoButton;
    [SerializeField] private GameObject secondInfoButton;
    [SerializeField] private GameObject thirdInfoButton;

    public void TapToScanButton()
    {
        TapToScanPage.gameObject.SetActive(false);
        ChildrenOrGuardianPage.gameObject.SetActive(true);
    }

    public void TapForChildren()
    {
        ChildrenOrGuardianPage.gameObject.SetActive(false);
        ChildrenPage.gameObject.SetActive(true);
    }
    public void TapForGuardian()
    {
        ChildrenOrGuardianPage.gameObject.SetActive(false);
        GuardianPage.gameObject.SetActive(true);
    }

    public void firstInfo()
    {
        firstInfoButton.gameObject.SetActive(true);
    }

    public void secondInfo()
    {
        secondInfoButton.gameObject.SetActive(true);
    }

    public void thirdInfo()
    {
        thirdInfoButton.gameObject.SetActive(true);
    }
}
