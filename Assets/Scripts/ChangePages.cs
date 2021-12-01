using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePages : MonoBehaviour
{
    bool showImages1 = false;
    bool showImages2 = false;
    bool showImages3 = false;
    bool mapChanged = false;
    [SerializeField] private GameObject tutorialSCreen;
    [SerializeField]  Image[] tutorialButtons;
    [SerializeField] private GameObject mapPic;
    [SerializeField] private GameObject mapINfo;
    [SerializeField] private GameObject kidsMapScreen;
    [SerializeField] private GameObject tutorial2;
    [SerializeField] private GameObject tutorial3;
    [SerializeField] private GameObject approved;
    [SerializeField] private GameObject disproved;
    [SerializeField] private GameObject parrotScreen;
    [SerializeField] private GameObject kidsScreen;
    [SerializeField] private GameObject secondKidScreen;
    [SerializeField] private GameObject goKidsScreen;
    [SerializeField] private GameObject welcomeParentScreen;
    [SerializeField] private GameObject animalScreenKids;
    [SerializeField] private GameObject startParentScreen;
    [SerializeField] private GameObject charityScreen;
    [SerializeField] private GameObject mapScreen;
    [SerializeField] private GameObject quizScreen;
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


    public void NewTutorial()
    {
        TaskScreen.gameObject.SetActive(false);
        tutorial2.gameObject.SetActive(true);
    }

    public void NewTutorial2()
    {
        TaskScreen.gameObject.SetActive(false);
        tutorial2.gameObject.SetActive(false);
        tutorial3.gameObject.SetActive(true);
    }

    public void Approved()
    {
        parrotScreen.gameObject.SetActive(false);
        approved.gameObject.SetActive(true);
    }

    public void disproved2()
    {
        parrotScreen.gameObject.SetActive(false);
        disproved.gameObject.SetActive(true);
    }

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

    public void goParrot()
    {
        parrotScreen.gameObject.SetActive(true);
        goKidsScreen.gameObject.SetActive(false);
        kidsScreen.gameObject.SetActive(false);
        secondKidScreen.gameObject.SetActive(false);
        
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

    public void toCharityScreen()
    {
        kidsScreen.gameObject.SetActive(false);
        secondKidScreen.gameObject.SetActive(false);
        goKidsScreen.gameObject.SetActive(false);
        kidsScreen.gameObject.SetActive(false);
        animalScreenKids.gameObject.SetActive(false);
        charityScreen.gameObject.SetActive(true);
        startParentScreen.gameObject.SetActive(false);
    }

    public void toStartParentScreen()
    {
        goKidsScreen.gameObject.SetActive(false);
        animalScreenKids.gameObject.SetActive(false);
        startParentScreen.gameObject.SetActive(true);
        charityScreen.gameObject.SetActive(false);
    }

    public void secondLibraryPage()
    {
        kidsScreen.gameObject.SetActive(false);
        secondKidScreen.gameObject.SetActive(true);
    }

    public void firstLibraryPage()
    {
        kidsScreen.gameObject.SetActive(true);
        secondKidScreen.gameObject.SetActive(false);
    }
    public void toAnimalScreenKids()
    {
        goKidsScreen.gameObject.SetActive(false);
        animalScreenKids.gameObject.SetActive(true);
        startParentScreen.gameObject.SetActive(false);
        charityScreen.gameObject.SetActive(false);
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


    public void goKidsPage()
    {
        kidsScreen.gameObject.SetActive(true);
        startParentScreen.gameObject.SetActive(false);
        charityScreen.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(false);
        goKidsScreen.gameObject.SetActive(false);
    }

    public void KidsScreeny()
    {
        kidsScreen.gameObject.SetActive(false);
        startParentScreen.gameObject.SetActive(false);
        charityScreen.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(false);
        goKidsScreen.gameObject.SetActive(true);
    }

    public void goParentMap()
    {
        kidsScreen.gameObject.SetActive(false);
        startParentScreen.gameObject.SetActive(true);
        charityScreen.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(false);
        goKidsScreen.gameObject.SetActive(false);
    }
    public void backToMapOrAnimalScreen()
    {
        ChildrenOrGuardianPage.gameObject.SetActive(false);
        mapOrAnimalScreen.gameObject.SetActive(true);
        animalScreen.gameObject.SetActive(false);
        TaskScreen.gameObject.SetActive(false);
        tutorial2.gameObject.SetActive(false);
        tutorial3.gameObject.SetActive(false);
        kidsMapScreen.gameObject.SetActive(false);  
    }

    public void GoToKidsScreenMap()
    {
        mapOrAnimalScreen.gameObject.SetActive(false);
        kidsMapScreen.gameObject.SetActive(true);

    }

    public void toggleMap()
    {
        if(!mapChanged)
        {
            mapPic.gameObject.SetActive(false);
            mapINfo.gameObject.SetActive(true);
            mapChanged = true;
            Debug.Log("yooooo");
            Debug.Log(mapChanged);
        }

        else if (mapChanged = true)
        {
            mapPic.gameObject.SetActive(true);
            mapINfo.gameObject.SetActive(false);
            mapChanged = false;
            Debug.Log("yeet");
        }
    }

    public void tochildrenOrGuardianPage()
    {

        ChildrenOrGuardianPage.gameObject.SetActive(false);
        ChildrenOrGuardianPage.gameObject.SetActive(true);
        animalScreen.gameObject.SetActive(false);
        TaskScreen.gameObject.SetActive(false);
        tutorial2.gameObject.SetActive(false);
        tutorial3.gameObject.SetActive(false);
        kidsMapScreen.gameObject.SetActive(false);
    }

    public void toParentPage()
    {
        if(showImages1 == false)
        {
            showImages1 = true;
            tutorialButtons[0].gameObject.SetActive(true);
        } else if (showImages2 == false)
        {
            showImages2 = true;
            tutorialButtons[1].gameObject.SetActive(true);
        } else if (showImages3 == false)
        {
            showImages3 = true;
            tutorialButtons[2].gameObject.SetActive(true);
        } else
        {
            ChildrenOrGuardianPage.gameObject.SetActive(false);
            WelcomeGuardianPage.gameObject.SetActive(true);
            tutorialSCreen.gameObject.SetActive(false);
        }
    }

    public void toMapScreen()
    {
        mapOrAnimalScreen.gameObject.SetActive(false);
        mapScreen.gameObject.SetActive(true);
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

    public void toQuiz()
    {
        mapOrAnimalScreen.gameObject.SetActive(false);
        quizScreen.gameObject.SetActive(true);
        
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
        parrotInfoPage.gameObject.SetActive(false);
    }
    public void takeBearPic()
    {
        pages.PickBear();
        bearInfoPage.gameObject.SetActive(false);
    }
    public void takeZebraPic()
    {
        pages.PickZebra();
        zebraInfoPage.gameObject.SetActive(false);
    }
    public void takeDolphinPic()
    {
        pages.PickDolphin();
        dolphinInfoPage.gameObject.SetActive(false);
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
