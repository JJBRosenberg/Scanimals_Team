using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPages : MonoBehaviour
{
    [SerializeField] private GameObject originalCamera;
    [SerializeField] private GameObject animalScreen;
    [SerializeField] private GameObject parrotScreen;
    [SerializeField] private GameObject bearScreen;
    [SerializeField] private GameObject zebraScreen;
    [SerializeField] private GameObject dolphinScreen;

    // Start is called before the first frame update
    public void PickParrot()
    {
        originalCamera.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(false);
        parrotScreen.gameObject.SetActive(true);
    }

    public void PickBear()
    {
        originalCamera.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(false);
        bearScreen.gameObject.SetActive(true);
    }

    public void PickZebra()
    {
        originalCamera.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(false);
        zebraScreen.gameObject.SetActive(true);
    }

    public void PickDolphin()
    {
        originalCamera.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(false);
        dolphinScreen.gameObject.SetActive(true);
    }
}
