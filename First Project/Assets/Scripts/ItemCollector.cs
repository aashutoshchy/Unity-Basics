using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] TMP_Text coinsText;
    [SerializeField] AudioSource coinCollected;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinCollected.Play();
            Destroy(other.gameObject);
            coins++;

            coinsText.text = "Coins: " + coins;
        }
    }
}