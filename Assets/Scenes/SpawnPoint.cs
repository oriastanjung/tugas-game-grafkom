using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject[] spawnLocation;
    public GameObject targetDeliverObject;

    private Vector3 respawnLocation;

    void Awake()
    {
        spawnLocation = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }
     void OnEnable()
    {
        targetDeliverObject = (GameObject)Resources.Load("TargetDeliver", typeof(GameObject));
        respawnLocation = targetDeliverObject.transform.position;

        SpawnTargetDeliver();
        Debug.Log("target deliver dibuat");
    }

    void SpawnTargetDeliver()
    {
        int spawnPoint = Random.Range(0, spawnLocation.Length);
        GameObject.Instantiate(targetDeliverObject, spawnLocation[spawnPoint].transform.position, Quaternion.identity);
    }
}
