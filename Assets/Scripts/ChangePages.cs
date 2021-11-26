using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePages : MonoBehaviour
{
    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject parrotInfoPage;
    [SerializeField] private GameObject bearInfoPage;
    [SerializeField] private GameObject zebraInfoPage;
    [SerializeField] private GameObject dolphinInfoPage;
    [SerializeField] private GameObject TapToScanPage;
    [SerializeField] private GameObject TaskScreen;
    [SerializeField] private GameObject ChildrenOrGuardianPage;
    [SerializeField] private GameObject ChildrenPage;
    [SerializeField] private GameObject GuardianPage;
    [SerializeField] private GameObject WelcomeGuardianPage;
    [SerializeField] private GameObject bothPanelScreen;
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
        bothPanelScreen.gameObject.SetActive(true);
    }
    public void TapForGuardian()
    {
        ChildrenOrGuardianPage.gameObject.SetActive(false);
        GuardianPage.gameObject.SetActive(true);
    }

    public void StartToTap()
    {
        startScreen.gameObject.SetActive(false);
        TapToScanPage.gameObject.SetActive(true);
    }

    public void firstInfo()
    {
        firstInfoButton.gameObject.SetActive(true);
    }

    public void backToMapFromTask()
    {
        TaskScreen.gameObject.SetActive(false);
        mapOrAnimalScreen.gameObject.SetActive(true);
    }

    public void backToAnimalScreen()
    {
        parrotInfoPage.gameObject.SetActive(false);
        bearInfoPage.gameObject.SetActive(false);
        zebraInfoPage.gameObject.SetActive(false);
        dolphinInfoPage.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(true);

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

    public void backToBothPanel()
    {
        mapOrAnimalScreen.gameObject.SetActive(false);
        bothPanelScreen.gameObject.SetActive(true);
    }

    public void backToMapOrAnimalScreen()
    {
        mapOrAnimalScreen.gameObject.SetActive(true);
        animalScreen.gameObject.SetActive(false);
    }

    public void toTask()
    {
        mapOrAnimalScreen.gameObject.SetActive(false);
        TaskScreen.gameObject.SetActive(true);
    }

    public void toTapScreen()
    {
        mapOrAnimalScreen.gameObject.SetActive(false);

    }

    public void backToHome()
    {
        WelcomeGuardianPage.gameObject.SetActive(false);
        ChildrenOrGuardianPage.gameObject.SetActive(true);
    }

    public void backToGuardian()
    {
        ChildrenOrGuardianPage.gameObject.SetActive(true);
        GuardianPage.gameObject.SetActive(false);
    }
    public void backToChildren()
    {
        ChildrenOrGuardianPage.gameObject.SetActive(true);
        bothPanelScreen.gameObject.SetActive(false);
    }
    public void Activate()
    {

        StartCoroutine(wait());

    }

    public void MapOrAnimal()
    {
        bothPanelScreen.gameObject.SetActive(false);
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
                animalScreen.gameObject.SetActive(false);
                parrotInfoPage.gameObject.SetActive(true);
                
                break;

            case (animals.BEAR):
                animalScreen.gameObject.SetActive(false);
                bearInfoPage.gameObject.SetActive(true);
                
                break;

            case (animals.ZEBRA):
                animalScreen.gameObject.SetActive(false);
                zebraInfoPage.gameObject.SetActive(true);
                
                break;

                case(animals.DOLPHIN):
                animalScreen.gameObject.SetActive(false);
                dolphinInfoPage.gameObject.SetActive(true);
                
                break;


        }
    }

    public void takeParrotPic()
    {
        pages.PickParrot();
    }
    public void takeBearPic()
    {
        pages.PickBear();
    }
    public void takeZebraPic()
    {
        pages.PickZebra();
    }
    public void takeDolphinPic()
    {
        pages.PickDolphin();
    }

    public void WelcomeGuardian()
    {
        GuardianPage.gameObject.SetActive(false);
        WelcomeGuardianPage.gameObject.SetActive(true);
    }

    IEnumerator wait()
    {
        firstScreen.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(transitionSpeed);
        firstScreen.gameObject.SetActive(false);

        secondScreen.gameObject.SetActive(true);
    }
}
