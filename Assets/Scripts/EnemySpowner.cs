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
    [SerializeField] float minTimeForSpawmEnemy = 1f;
    [SerializeField] float maxTimeForSpawnEnemy = 5f;


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
        Instantiate(enemyForSpawn, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
