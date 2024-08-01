using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UImanager : MonoBehaviour
{
    public float fadetime = 1f;
    public CanvasGroup canvasGroup;
    public RectTransform things;

    public List<GameObject> items = new List<GameObject>();
    public AudioClip pop_up;
    private AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        
    }

    public void panelfadein()
    {
        canvasGroup.alpha = 0f;
        things.transform.localPosition = new Vector3(0f, -600, 0f);
        things.DOAnchorPos(new Vector2(0f, 0f), fadetime, false).SetEase(Ease.OutElastic);
        canvasGroup.DOFade(1, fadetime);
        StartCoroutine("items_animation");
    }
    public void panelfadeout()
    {
        canvasGroup.alpha = 1f;
        things.transform.localPosition = new Vector3(0f, 0f, 0f);
        things.DOAnchorPos(new Vector2(0f, -1000), fadetime, false).SetEase(Ease.OutQuint);
        canvasGroup.DOFade(0, fadetime);
    }

    IEnumerator items_animation()
    {
        foreach(var item in items)
        {
            item.transform.localScale = Vector3.zero;
        }

        foreach(var item in items)
        {
            audiosource.PlayOneShot(pop_up);
            item.transform.DOScale(1f, fadetime).SetEase(Ease.OutBounce);
            yield return new WaitForSeconds(0.25f);
        }
    }

}
