using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDetection : MonoBehaviour
{
    //[SerializeField] private Animator myAnimControl;

    public AudioClip audioClip;

    public AudioSource audioSource;

    public static int numOfGems = 0;

    private void Start()
    {
        audioSource.clip = audioClip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Emerald")
        {
            //myAnimControl.SetBool("GemInsert", true);
            Debug.Log("Now we know...now we know");

            audioSource.Play();

            numOfGems++;
        }
    }
}
