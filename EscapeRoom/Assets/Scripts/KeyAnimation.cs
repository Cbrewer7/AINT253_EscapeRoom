using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimControl;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            myAnimControl.SetBool("IsOpenning", true);
            Debug.Log("Oppen sessimy");
        }
    }
}
