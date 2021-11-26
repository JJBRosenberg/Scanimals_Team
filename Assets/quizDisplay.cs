using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizDisplay : MonoBehaviour
{
    public QuizObject Quiz;

    public Text QuizQuestion;
    public Button QuizAnswer1;
    public Button QuizAnswer2;
    public Button QuizAnswer3;
    public int answerNumber;
    public Text RightOrWrong;

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
        } else
        {
            RightOrWrong.text = ("Wrong");
        }
    }

}
