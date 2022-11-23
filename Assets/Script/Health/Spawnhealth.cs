using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnhealth : MonoBehaviour
{
    [SerializeField] GameObject healthPrefab;
    [SerializeField] float spawnTimer = 10f;


    private void Start()
    {
        StartCoroutine(spawnHealth(spawnTimer, healthPrefab));
    }

    private IEnumerator spawnHealth(float spawntime, GameObject health)
    {
        yield return new WaitForSeconds(spawntime);
        GameObject newEnemy = Instantiate(health, new Vector3(Random.Range(-25, 25), 0, 0), Quaternion.identity);
        StartCoroutine(spawnHealth(spawntime, health));
    }
}
