using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tweening : MonoBehaviour
{
    public GameObject player;
    public GameObject endpos;
    public int speed;
    //public int num_of_jumps;
    //public int jump_height;
    void Start()
    {
        //player.transform.DOMove(new Vector3(endpos.transform.position.x, endpos.transform.position.y + 5, endpos.transform.position.z), speed);
        //player.transform.DOMoveX(endpos.transform.position.x, speed);
        //player.transform.DOMoveY(endpos.transform.position.y, speed);
        //player.transform.DOMoveZ(endpos.transform.position.z, speed);
        //player.transform.DOJump(new Vector3(endpos.transform.position.x, endpos.transform.position.y, endpos.transform.position.z),jump_height,num_of_jumps,speed,false);
        //player.transform.DORotate(new Vector3(0,150,0),speed,RotateMode.Fast);
        player.transform.DOLookAt(new Vector3(endpos.transform.position.x, endpos.transform.position.y, endpos.transform.position.z),speed,AxisConstraint.None,Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
