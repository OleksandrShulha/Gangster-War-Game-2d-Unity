using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWeapon : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float damage = 20f;

    // Update is called once per frame
    void Update()
    {
        MoveWeaponOntarget();
    }



    //метод полета снаряда
    void MoveWeaponOntarget()
    {
        var deltaX = Time.deltaTime * speed;
        transform.position = new Vector2(transform.position.x + deltaX, transform.position.y);

        //такой способ не позволяет вращаться анимации
        //transform.Translate(Vector2.right * speed * Time.deltaTime);
    }



    //метод столкновения снаряда с врагом вызывает метод нанисения урона
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //создаем переменную в которую заносим наш обьект столкновения
        var health = otherCollider.GetComponent<Health>();
        //получаем доступ к нашему врагу
        var enemy = otherCollider.GetComponent<Enemy1>();


        if (health && enemy)
        {
            //вызываем метод урона
            health.DealDamage(damage);
            //уничтожаем динамит
            Destroy(gameObject);
        }

    }
}
