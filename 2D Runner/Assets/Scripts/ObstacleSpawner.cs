using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawnTime;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        int i = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[i], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer >= spawnTime)
        {
            int i = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[i],transform.position,Quaternion.identity);
            timer = 0;
        }
    }
}
