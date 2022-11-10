using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositionCoin : MonoBehaviour
{

    private void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(0,1), UnityEngine.Random.Range(0, 1));
    }

}
