using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpowner : MonoBehaviour
{
    //обьект для спанв
    [SerializeField]  Enemy1 enemyForSpawn;

    //если ТРЮ - то спавним врагов
    bool spawnEnemy = true;

    //время спавна врагово
    [SerializeField] float minTimeForSpawmEnemy = 10f;
    [SerializeField] float maxTimeForSpawnEnemy = 20f;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawnEnemy)
        {
            yield return new WaitForSeconds(Random.Range(minTimeForSpawmEnemy, maxTimeForSpawnEnemy));
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        Enemy1 newEnemy1 =  Instantiate(enemyForSpawn, transform.position, transform.rotation) as Enemy1;
        //заносим Атакеров в как дочерний обьект точки спавна
        newEnemy1.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
