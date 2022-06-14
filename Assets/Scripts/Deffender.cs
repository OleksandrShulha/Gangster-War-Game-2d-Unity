using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deffender : MonoBehaviour
{
    //стартовая цена покупки защитников
    [SerializeField] int startCost = 100;

    public void AddScore(int amount)
    {
        FindObjectOfType<ScoreDispley>().AddScore(amount);
    }

    public int GetStartCoast()
    {
        return startCost;
    }
}
