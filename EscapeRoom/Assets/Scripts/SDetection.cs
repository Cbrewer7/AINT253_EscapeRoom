using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SDetection : MonoBehaviour
{
    [SerializeField] private Animator myAnimControl;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sapphire")
        {
            myAnimControl.SetBool("GemInsert", true);
            Debug.Log("Now we know...now we know");
        }
    }
}
