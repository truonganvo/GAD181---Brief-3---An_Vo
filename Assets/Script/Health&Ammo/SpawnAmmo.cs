using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAmmo : MonoBehaviour
{
    [SerializeField] GameObject ammoPrefab;
    [SerializeField] float spawnTimer = 5f;


    private void Start()
    {
        StartCoroutine(spawnHealth(spawnTimer, ammoPrefab));
    }

    private IEnumerator spawnHealth(float spawntime, GameObject ammo)
    {
        yield return new WaitForSeconds(spawntime);
        GameObject newAmmo = Instantiate(ammo, new Vector3(Random.Range(-26, 27), Random.Range(38, 56), 0), Quaternion.identity);
        StartCoroutine(spawnHealth(spawntime, ammo));
    }
}
