using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uityloading : MonoBehaviour
{

    public GameObject loading;
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        loading.SetActive(true);
        ui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("active_mainui", 4f);
    }
    public void active_mainui()
    {
        ui.SetActive(true);
        loading.SetActive(false);
    }
}
