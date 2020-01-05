using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPull2 : MonoBehaviour
{
    public bool on2 = false;

    public Light lt;

    void Start()
    {
        lt.color = Color.black;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && !on2)
        {
            Debug.Log("AHHHHHH");
            on2 = true;
            lt.color = Color.red;
        }
        else if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && on2)
        {
            Debug.Log("Has it actually worked?");
            on2 = false;
            lt.color = Color.black;
        }
    }
}
