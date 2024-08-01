using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float jmp_height;
    public Animator playerAnimator;
    public float anim_speed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            playerAnimator.SetFloat("Speed", anim_speed);
            if (playerAnimator != null)
            {
                playerAnimator.SetBool("Jump",true);
                playerRigidbody.AddForce(Vector3.up * 10f * jmp_height, ForceMode.Impulse);
                StartCoroutine(back());
            }
        }
    }
    IEnumerator back()
    {
        // Wait for the duration of the attack animation
        yield return new WaitForSeconds(1f);

        playerAnimator.SetBool("Jump", false);
    }
}
