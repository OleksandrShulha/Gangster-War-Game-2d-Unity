using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeffenderButton : MonoBehaviour
{
    //Вносым префаб защитников
    [SerializeField] Deffender deffnederPrefab;

    private void OnMouseDown()
    {
        //ищем все обьекты DeffenderButton
        var buttons = FindObjectsOfType<DeffenderButton>();
        //перебираем их и ставим цвет по умолчанию
        foreach(DeffenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }
        //ставим цвет по клику
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpowner>().SetSelectedDeffender(deffnederPrefab);
    }
}
