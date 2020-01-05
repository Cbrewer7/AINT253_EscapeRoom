using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPull3 : MonoBehaviour
{
    public bool on3 = false;
    
    public Light lt;

    void Start()
    {
        lt.color = Color.black;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && !on3)
        {
            Debug.Log("AHHHHHH");
            on3 = true;
            lt.color = Color.red;
        }
        else if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && on3)
        {
            Debug.Log("Has it actually worked?");
            on3 = false;
            lt.color = Color.black;
        }
    }
}
