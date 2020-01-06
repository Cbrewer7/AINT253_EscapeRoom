using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimControl;

    
    public AudioClip playClip;
    public AudioSource playSource;

    public AudioClip playClip2;
    public AudioSource playSource2;

    void Start()
    {
        playSource.clip = playClip;
        playSource2.clip = playClip2;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Key")
        {
            playSource.Play();
            playSource2.Play();

            myAnimControl.SetBool("IsOpenning", true);
            Debug.Log("Oppen sessimy");
        }
    }
}
