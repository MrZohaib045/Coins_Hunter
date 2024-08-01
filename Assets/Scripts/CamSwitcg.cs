using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitcg : MonoBehaviour
{
    public float horizontalForce = 5f;
    public float verticalForce = 10f;
    private Rigidbody rb;

    public GameObject target;
    public Camera cam;

    public Vector3 offset = new Vector3(0, 3, -5);

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(horizontalInput * horizontalForce, 0f, verticalInput * verticalForce);
        rb.AddForce(force);

        cam.transform.position = target.transform.position + offset;
    }
}
