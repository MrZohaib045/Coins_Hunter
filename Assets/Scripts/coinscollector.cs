using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class coinscollector : MonoBehaviour
{
    private int coins = 0;
    public TextMeshProUGUI coin_text;
    public AudioSource play_kr_oye;

    private const string CoinKey = "Coins"; // Key to identify the stored coin value

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            coins++;
            play_kr_oye.Play();
            coin_text.text = coins.ToString();
            PlayerPrefs.SetInt(CoinKey, coins); // Store the updated total in PlayerPrefs
            PlayerPrefs.Save(); // Save the PlayerPrefs
            print(coins);
            Destroy(other.gameObject);
        }
    }

    private void Start()
    {
        save();
    }

    public void save()
    {
        // Load the stored number of coins when the script starts
        coins = PlayerPrefs.GetInt(CoinKey, coins);
        coin_text.text = coins.ToString();
    }


    public void loadmenu()
    {
        SceneManager.LoadScene(0);
    }
}
