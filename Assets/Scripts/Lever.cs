using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Transform handle; // Reference to the lever handle
    public float targetRotationX = -45f; // Target rotation on the X-axis
    public GameObject object_to_hide;
    public GameObject object_to_show;

    void Start()
    {
        object_to_hide.SetActive(true);
        object_to_show.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RotateHandle();
            object_to_hide.SetActive(false);
            object_to_show.SetActive(true);
        }
    }

    private void RotateHandle()
    {
        if (handle != null)
        {
            Vector3 targetRotation = new Vector3(targetRotationX, handle.rotation.y, handle.rotation.z);
            handle.rotation = Quaternion.Euler(targetRotation);
        }
    }
}
