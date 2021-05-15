//Justin Clark
//April 21, 2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMinions : MonoBehaviour
{
    public float timer;
    public GameObject minion;
    public GameObject[] spawnpoint;
    GameObject clone;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f) // If the set timer reaches 0
        {
            SpawnMinion(); // Spawns a specific minion to increase difficulty of the boss fight
            timer = 30f; //Then resets the timer to 30 seconds
        }
    }

    void SpawnMinion()
    {
        int location = Random.Range(0, 37);
        clone = Instantiate(minion, new Vector3(0, 0.5f, 0), Quaternion.identity) as GameObject;
        clone.transform.position = spawnpoint[location].transform.position;
    }
}
