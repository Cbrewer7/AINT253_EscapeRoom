using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public GameObject light;
    private bool on = false;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Destination" && Input.GetKeyDown(KeyCode.E) && !on)
        {
            Debug.Log("AHHHHHH");
            light.SetActive(true);
            on = true;
        }
        if (other.tag == "Destination" && Input.GetKeyDown(KeyCode.E) && !on)
        {
            //Debug.Log("AHHHHHH");
            light.SetActive(false);
            on = false;
        }
    }
}
