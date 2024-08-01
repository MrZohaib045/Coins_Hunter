using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using TMPro;

public class animatemenu : MonoBehaviour
{
    public GameObject loading;
    public GameObject menu;

    public RectTransform mainmenu;
    public RectTransform settingmenu;
    public float speed;

    void Start()
    {
        loading.SetActive(true);
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("active_mainmenu", 4f);
    }

    public void onclicksetting()
    {
        mainmenu.DOAnchorPos(new Vector2(1250,0),speed,false);
        settingmenu.DOAnchorPos(new Vector2(0, 0), speed, false);
    }

    public void onclickback()
    {
        mainmenu.DOAnchorPos(new Vector2(0, 0), speed, false);
        settingmenu.DOAnchorPos(new Vector2(-1250, 0), speed, false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void active_mainmenu()
    {
        menu.SetActive(true);
        loading.SetActive(false);
    }

    public void load_next_level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
