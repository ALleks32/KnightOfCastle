using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextInfo : MonoBehaviour
{
    public GameObject NextTable;
    public bool Active = false;

    public void FixedUpdate()
    {
        if(Active == true)
        NextTable.SetActive(true);
    }
}
