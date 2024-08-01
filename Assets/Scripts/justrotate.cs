using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justrotate : MonoBehaviour
{
    public float minSpeed = 100f;
    public float maxSpeed = 500f;
    public float turnspeed;

    void Start()
    {
        turnspeed = Random.Range(minSpeed, maxSpeed);
    }

    private void Update()
    {
        transform.Rotate(0, turnspeed * Time.deltaTime, 0);
    }
}
