using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emenypyattack : MonoBehaviour
{
    public LayerMask enemyLayer; // Define the layer for enemy objects
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ground") && collision.collider.CompareTag("ground"))
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, 10f, enemyLayer);

            foreach (Collider hitCollider in hitColliders)
            {
                // Destroy enemy objects within range
                if (hitCollider.CompareTag("enemy"))
                {
                    Destroy(hitCollider.gameObject);
                }
            }
        }
    }
}
