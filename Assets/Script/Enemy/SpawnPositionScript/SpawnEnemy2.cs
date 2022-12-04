using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy2 : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefabs;
    [SerializeField] float spawnTimer = 5f;


    private void Start()
    {
        StartCoroutine(spawnEnemy(spawnTimer, enemyPrefabs));
    }

    private IEnumerator spawnEnemy(float spawntime, GameObject enemy)
    {
        yield return new WaitForSeconds(spawntime);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-32, -39), Random.Range(46, 59), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(spawntime, enemy));
    }
}
