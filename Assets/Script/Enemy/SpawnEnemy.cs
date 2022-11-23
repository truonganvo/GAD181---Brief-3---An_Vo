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
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-27f, 30), Random.Range(30, 35), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(spawntime, enemy));
    }
}
