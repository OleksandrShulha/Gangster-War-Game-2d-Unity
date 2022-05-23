using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDispley : MonoBehaviour
{
    [SerializeField] int score = 100;
    Text startScore;

    void Start()
    {
        startScore = GetComponent<Text>();
        UpdateScore();
    }

    
    private void UpdateScore()
    {
        startScore.text = score.ToString();
    }


    //добавляем очки
    public void AddScore(int scoreCost)
    {
        score += scoreCost;
        UpdateScore();
    }

    //убираем очки
    public void SpendScore(int scoreCost)
    {
        if (score <= scoreCost)
        {
            score -= scoreCost;
            UpdateScore();
        }

    }
}
