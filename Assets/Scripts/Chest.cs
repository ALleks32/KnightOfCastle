using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    
    int ValueCoins= 5;
    public GameObject Coin;
    public bool Open;
    AudioSource audioOpen;
    public GameObject Table;


    private void Start()
    {
        audioOpen = gameObject.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (Open == true)
        {
           gameObject.GetComponent<Animator>().SetBool("Open", true);
            for (int i = 0; i < ValueCoins; i++)
            {
                audioOpen.Play();
                float r = 0;
                r = Random.RandomRange(0, 0.3f);

                Instantiate(Coin, new Vector2(gameObject.transform.position.x , gameObject.transform.position.y + r), Quaternion.identity);
                
            }
            Destroy(Table);
            Destroy(gameObject.GetComponent<Chest>());
        }
    }
}
