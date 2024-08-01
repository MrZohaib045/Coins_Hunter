using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    //public GameObject obj3;

    void Start()
    {
        obj1.SetActive(true);
        obj2.SetActive(false);
       // obj3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gotosetting()
    {
        if (obj1.activeInHierarchy)
        {
            obj1.SetActive(false);
            obj2.SetActive(true);
        }
        else
        {
            obj1.SetActive(true);
            obj2.SetActive(false);
        }
    }
}
