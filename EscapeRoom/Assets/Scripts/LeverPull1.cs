using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPull1 : MonoBehaviour
{
    public bool on1 = false;

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
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && !on1)
        {
            Debug.Log("AHHHHHH");
            on1 = true;
            lt.color = Color.red;
            audioSource.Play();
        }
        else if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && on1)
        {
            Debug.Log("Has it actually worked?");
            on1 = false;
            lt.color = Color.black;
        }
    }
}
