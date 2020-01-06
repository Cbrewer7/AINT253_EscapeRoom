using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPull : MonoBehaviour
{
    //public GameObject light;
    public bool on = false;

    public AudioClip audioClip;

    public AudioSource audioSource;

    public AudioClip doorClip;

    public AudioSource doorSource;

    public AudioClip voiceClip;

    public AudioSource voiceSource;

    public Light lt;
    //public Animation anim;
    //public Transform destination;
    //private int colNum;

    [SerializeField] private Animator myAnimControl;

    // Start is called before the first frame update
    void Start()
    {
        lt.color = Color.black;
        //colNum = 1;

        audioSource.clip = audioClip;

        doorSource.clip = doorClip;

        voiceSource.clip = voiceClip;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && !on)
        {
            Debug.Log("AHHHHHH");
            //light.SetActive(true);
            on = true;
            lt.color = Color.red;
            myAnimControl.SetBool("DoorOpen", true);

            audioSource.Play();
            doorSource.Play();
            voiceSource.Play();
        }
        else if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && on)
        {
            Debug.Log("Has it actually worked?");
            //light.SetActive(false);
            on = false;
            lt.color = Color.black;
        }
        //if (other.tag == "Destination" && Input.GetKeyDown(KeyCode.F) && lt.color == Color.red)
        //{
        //    lt.color = Color.blue;

        //}
        //if (other.tag == "Destination" && Input.GetKeyDown(KeyCode.F) && lt.color == Color.blue)
        //{
        //    lt.color = Color.green;

        //}
    }
}
