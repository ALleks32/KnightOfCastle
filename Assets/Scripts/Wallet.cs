using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Wallet : MonoBehaviour
{
    public int Coins;
    public int Keys;
    public Text Valuecoins;
    public Text ValueKeys;
    public AudioClip HitSwordMp3;
    AudioSource AudioSourse;

    public void Start()
    {
        Valuecoins = GameObject.Find("Valuecoins").GetComponent<Text>();
        ValueKeys = GameObject.Find("ValueKeys").GetComponent<Text>();
        AudioSourse = gameObject.GetComponent<AudioSource>();
    }
   public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<NextInfo>())
        {
            collision.gameObject.GetComponent<NextInfo>().Active = true;
        }
        if (collision.gameObject.GetComponent<KeyValue>())
        {
            Keys += collision.gameObject.GetComponent<KeyValue>()._KeyValue;
            ValueKeys.text = Keys.ToString();
            Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.GetComponent<CoinValue>())
        {
            Coins += collision.gameObject.GetComponent<CoinValue>()._CoinValue;
            Valuecoins.text = Coins.ToString();
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.GetComponent<Chest>())
        {
            if (1 <= gameObject.GetComponent<Wallet>().Keys && Keys >= 1)
            {
                collision.GetComponent<Chest>().Open = true;
                Keys -= 1;
                ValueKeys.text = Keys.ToString();
            }
          
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {

    }
}
