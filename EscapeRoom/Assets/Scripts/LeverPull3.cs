using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPull3 : MonoBehaviour
{
    public bool on3 = false;
    
    public Light lt;

    public AudioClip audioClip;

    public AudioSource audioSource;

    void Start()
    {
        lt.color = Color.black;
        audioSource.clip = audioClip;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && !on3)
        {
            Debug.Log("AHHHHHH");
            on3 = true;
            lt.color = Color.red;
            audioSource.Play();
        }
        else if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && on3)
        {
            Debug.Log("Has it actually worked?");
            on3 = false;
            lt.color = Color.black;
        }
    }
}
