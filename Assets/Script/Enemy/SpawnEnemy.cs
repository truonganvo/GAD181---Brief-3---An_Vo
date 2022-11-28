using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
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
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-24f, 25), Random.Range(63, 72), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(spawntime, enemy));
    }
}
