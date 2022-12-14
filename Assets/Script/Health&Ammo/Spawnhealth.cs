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
        GameObject newHealth = Instantiate(health, new Vector3(Random.Range(-26, 27), Random.Range(35,30), 0), Quaternion.identity);
        StartCoroutine(spawnHealth(spawntime, health));
    }
}
