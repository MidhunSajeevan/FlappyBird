using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPipes : MonoBehaviour
{
    private float velocity = 0.5f;
   
    void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
