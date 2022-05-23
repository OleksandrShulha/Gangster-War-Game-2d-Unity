using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    //скорость ходьбы врага
    float curentSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * curentSpeed);
    }


    //метод который присваевает скорости новою скорость
    public void SetMovomentSpeed(float speed)
    {
        curentSpeed = speed;
    }

}
