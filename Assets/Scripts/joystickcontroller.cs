using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
public class joystickcontroller : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _moveSpeed = 5f;

    private void FixedUpdate()
    {
        Vector3 movementDirection = new Vector3(_joystick.Horizontal, 0f, _joystick.Vertical).normalized;

        if (movementDirection != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(movementDirection);
            _rigidbody.MoveRotation(Quaternion.RotateTowards(transform.rotation, lookRotation, Time.fixedDeltaTime * _moveSpeed * 100f));

            Vector3 movement = movementDirection * _moveSpeed * Time.fixedDeltaTime;
            _rigidbody.MovePosition(transform.position + movement);

            _animator.SetBool("isRun", true);
        }
        else
        {
            _animator.SetBool("isRun", false);
        }
    }

    public void onclick()
    {
        _animator.SetBool("Attack", true);
        StartCoroutine(ResetAttack());
    }
    IEnumerator ResetAttack()
    {
    // Wait for the duration of the attack animation
    yield return new WaitForSeconds(1f);

    // Reset the "Attack" parameter
    _animator.SetBool("Attack", false);
    }

    public void powerattack()
    {
        _animator.SetBool("jumpAttack", true);
        StartCoroutine(ResetjumpAttack());
    }
    IEnumerator ResetjumpAttack()
    {
        // Wait for the duration of the attack animation
        yield return new WaitForSeconds(1f);

        // Reset the "Attack" parameter
        _animator.SetBool("jumpAttack", false);
    }
}
