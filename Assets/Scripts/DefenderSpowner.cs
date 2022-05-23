using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpowner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClick());
    }

    private void SpawnDefender(Vector2 wordPos)
    {


        GameObject newDefender = Instantiate(defender, wordPos, Quaternion.identity) as GameObject;

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

}
