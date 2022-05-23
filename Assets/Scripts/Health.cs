using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour

{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deatchVFX;
    [SerializeField] int scoreEnemis = 50;

    //метод нанисения урона и смерти
    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            //вызываем эффект
            TrigerDeathVFX();
            Destroy(gameObject);
            FindObjectOfType<ScoreDispley>().AddScore(scoreEnemis);
        }
    }


    private void TrigerDeathVFX()
    {
        // если мы забыли добавить эффект просто выхол
        if (!deatchVFX) { return; }
        //создаем эффект
        GameObject deatchVFXObject =  Instantiate(deatchVFX, transform.position, transform.rotation);
        //уничтожаем эффект через 1 сек
        Destroy(deatchVFXObject, 1f);

    }
}
