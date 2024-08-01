using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameoye : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public float transitionDuration = 2.0f; 

    private Transform currentTarget;

    void Start()
    {
        currentTarget = target1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
   
            currentTarget = (currentTarget == target1) ? target2 : target1;

            StartCoroutine(SmoothTransition());
        }
    }

    IEnumerator SmoothTransition()
    {
        float elapsedTime = 0f;
        Vector3 startingPos = transform.position;
        Quaternion startingRot = transform.rotation;

        while (elapsedTime < transitionDuration)
        {
 
            transform.position = Vector3.Lerp(startingPos, currentTarget.position, elapsedTime / transitionDuration);
            transform.rotation = Quaternion.Slerp(startingRot, currentTarget.rotation, elapsedTime / transitionDuration);

 
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        transform.position = currentTarget.position;
        transform.rotation = currentTarget.rotation;
    }
}

