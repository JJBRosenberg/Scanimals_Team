using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.IO;
using System.IO;
public class loadAnimalPictures : MonoBehaviour
{
    public Text animalQuestions;
    public Image animalPicture;
    public Image backgroundColor;
    public Button[] answerbuttons;
    public string animal;
    public string animalPicName;

    public void Start()
    {
        animalPicture.sprite = GetSpriteFromFile(animalPicName);
        animalQuestions.text = "Is this a " + animal;
    }


    public void ifCorrect()
    {
        backgroundColor.color = Color.green;
        animalQuestions.text = "Yes it is a " + animal;
        answerbuttons[1].gameObject.SetActive(false);
        answerbuttons[0].gameObject.SetActive(false);
    }
    public void ifWrong()
    {
        backgroundColor.color = Color.red;
        animalQuestions.text = "No this is a " + animal;
        answerbuttons[1].gameObject.SetActive(false);
        answerbuttons[0].gameObject.SetActive(false);
    }

    public static Sprite GetSpriteFromFile(string file)
    {
        var res = Resources.Load(file) as Texture2D;
        Rect rec = new Rect(0, 0, res.width, res.height);
        return Sprite.Create(res, rec, Vector2.zero);
    }
}
