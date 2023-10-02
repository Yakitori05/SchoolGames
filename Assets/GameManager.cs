using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformcount = 300;

    void Start()
    {
        Vector3 spawnposition = new Vector3();

        for (int i = 0; i < platformcount; i++)
        {
            spawnposition.y += Random.Range(.5f, 2f);
            spawnposition.x = Random.Range(-5f, 5f);
            Instantiate(platformPrefab, spawnposition, Quaternion.identity);
        }
    }
}
