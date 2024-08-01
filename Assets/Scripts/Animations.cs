using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator anim;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("isWalk", true);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool("isRun", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("isRun", false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("jumpAttack", true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            anim.SetBool("jumpAttack", false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetBool("isDance", true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            anim.SetBool("isDance", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Attack", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("Attack", false);
        }

    }
}
