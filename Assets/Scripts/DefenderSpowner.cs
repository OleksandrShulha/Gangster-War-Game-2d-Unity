using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpowner : MonoBehaviour
{

    Deffender defender;

    private void OnMouseDown()
    {
        AttempToPlaceDeffender(GetSquareClick());
    }

    private void SpawnDefender(Vector2 wordPos)
    {


        Deffender newDefender = Instantiate(defender, wordPos, Quaternion.identity) as Deffender;

    }


    private Vector2 GetSquareClick()
    {
        //переменная которая принимает позицию миши по х и по у
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //преобразовываем нашу переменную в мировые еденицы что мы сделали
        Vector2 wordPos = Camera.main.ScreenToWorldPoint(clickPos);
        //преобразовываем координаты с привыязкой к сетке
        Vector2 gripPos = SnapToGrid(wordPos);


        //возвращем наши новые координаты
        return gripPos;
    }

    private Vector2 SnapToGrid(Vector2 oldWordPosition)
    {
        //преобразовываем координату Х в Инт
        float newX = Mathf.RoundToInt(oldWordPosition.x);
        float newY = Mathf.RoundToInt(oldWordPosition.y);
        return new Vector2(newX, newY); 
    }

    //выбор кого спавнить
    public void SetSelectedDeffender(Deffender defennderToSelect)
    {
        defender = defennderToSelect;
    }


    //метод спавна при наличии денег
    private void AttempToPlaceDeffender(Vector2 gridPos)
    {
        //заносим цену для спавна
        int deffenderCoast = defender.GetStartCoast();
        //подтягиваем обьекты класса scrore
        var StartDisplay = FindObjectOfType<ScoreDispley>();

        //если денег хватает спавним защитника и спысываем денгьги
        if (StartDisplay.HaveEnoughtSrars(deffenderCoast))
        {
            SpawnDefender(gridPos);
            StartDisplay.SpendScore(deffenderCoast);
        }
    }

}
