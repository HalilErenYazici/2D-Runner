using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(transform.right*-1*speed*Time.deltaTime);   
    }
}
