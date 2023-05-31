using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI correct_scoreText;
    //public TextMeshProUGUI final_correct_Text;
    public int score;
    private int final_score;
    //public TextMeshProUGUI wrong_scoreText;
    //private int wrong_score;
    void Start()
    {
        score= 0;
        final_score = 0;
    }
    public void UpdateScore(int Addone)
    {
        Debug.Log(score);
        score += Addone;
        if(score%13==0 && score != 0)
        {
            final_score++;
            score = 0;
        }
        correct_scoreText.text = "成功次數: " + final_score;
        //final_correct_Text.text = "成功次數: " + score;
        //wrong_scoreText.text = "錯誤次數: " + wrong_score;

    }
    
}
