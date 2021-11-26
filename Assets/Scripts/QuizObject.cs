using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu()]
public class QuizObject : ScriptableObject
{
    public string QuizQuestion;
    public string AnswerOne;
    public string AnswerTwo;
    public string AnswerThree;
    public int answerNumber;
    public GameObject nextPage;



}
