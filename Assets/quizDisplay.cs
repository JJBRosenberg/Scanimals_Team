using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizDisplay : MonoBehaviour
{
    public QuizObject Quiz;
    public GameObject here;
    public GameObject nextPage;
    public Text QuizQuestion;
    public Button QuizAnswer1;
    public Button QuizAnswer2;
    public Button QuizAnswer3;
    public int answerNumber;
    public Text RightOrWrong;
    public Button goNext;
    public Button back;
    public GameObject animalScreen;
    public GameObject herePanel;

    private void Start()
    {
        QuizQuestion.text = Quiz.QuizQuestion;
        QuizAnswer1.GetComponentInChildren<Text>().text = ("1:") + Quiz.AnswerOne;
        QuizAnswer2.GetComponentInChildren<Text>().text = ("2:") + Quiz.AnswerTwo;
        QuizAnswer3.GetComponentInChildren<Text>().text = ("3:") + Quiz.AnswerThree;
        answerNumber = Quiz.answerNumber;
    }



    public void quizAttempt(int value)
    {
        if(value == answerNumber)
        {
            RightOrWrong.text = ("Correct");
            goNext.gameObject.SetActive(true);
        } else
        {
            RightOrWrong.text = ("Wrong");
        }
    }

    public void nextPageFunction()
    {
        here.gameObject.SetActive(false);
        nextPage.gameObject.SetActive(true);
    }
    

    public void backButton()
    {
        herePanel.gameObject.SetActive(false);
        animalScreen.gameObject.SetActive(true);
    }
    
}
