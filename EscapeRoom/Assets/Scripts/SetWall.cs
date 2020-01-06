using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWall : MonoBehaviour
{
    public AudioClip audioClip;

    public AudioSource audioSource;
    private void Start()
    {
        audioSource.clip = audioClip;
    }

    void Update()
    {
        if (this.gameObject.GetComponent<MeshRenderer>().enabled == false)
        {
            audioSource.Play();
        }
    }
}
