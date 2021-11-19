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
    [SerializeField] private GameObject backToTapScreenButton;
    [SerializeField] private GameObject backToChildrenOrButton;
    [SerializeField] private GameObject backToGuardianOrButton;
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;
    [SerializeField] private GameObject mapOrAnimalScreen;
    [SerializeField] private GameObject animalScreen;
    [SerializeField] private int transitionSpeed;
    public AnimalPages pages;
    private string Parrot = "parrot";


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

    public void backToTapScreen()
    {
        ChildrenOrGuardianPage.gameObject.SetActive(false);
        TapToScanPage.gameObject.SetActive(true);
    }

    public void backToGuardian()
    {
        ChildrenOrGuardianPage.gameObject.SetActive(true);
        GuardianPage.gameObject.SetActive(false);
    }
    public void backToChildren()
    {
        ChildrenOrGuardianPage.gameObject.SetActive(true);
        ChildrenPage.gameObject.SetActive(false);
    }
    public void Activate()
    {

        StartCoroutine(wait());

    }

    public void MapOrAnimal()
    {
        secondScreen.gameObject.SetActive(false);
        mapOrAnimalScreen.gameObject.SetActive(true);
    }

    public void AnimalScreen()
    {
        mapOrAnimalScreen.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(true);    
    }

    public enum animals { 
        PARROT,
        BEAR, 
        ZEBRA,
        DOLPHIN
    }
    
    public void PickAnimal(int someValue)
    {
        switch((animals)someValue)
        {
            case (animals.PARROT):
                pages.PickParrot();
                break;

            case (animals.BEAR):
                pages.PickBear();
                break;

            case (animals.ZEBRA):
                pages.PickZebra();
                break;

                case(animals.DOLPHIN):
                pages.PickDolphin();
                break;


        }
    }

    
    IEnumerator wait()
    {
        firstScreen.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(transitionSpeed);
        firstScreen.gameObject.SetActive(false);

        secondScreen.gameObject.SetActive(true);
    }
}
