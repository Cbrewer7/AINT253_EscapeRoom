using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPull1 : MonoBehaviour
{
    public bool on1 = false;

    public Light lt;
    
    void Start()
    {
        lt.color = Color.black;
     
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && !on1)
        {
            Debug.Log("AHHHHHH");
            on1 = true;
            lt.color = Color.red;
        }
        else if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && on1)
        {
            Debug.Log("Has it actually worked?");
            on1 = false;
            lt.color = Color.black;
        }
    }
}
