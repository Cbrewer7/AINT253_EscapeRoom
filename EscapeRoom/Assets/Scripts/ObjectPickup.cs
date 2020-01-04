using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour
{
    //Original Credit to Jimmy Vegas for pickup tutorial
    // https://www.youtube.com/watch?v=IEV64CLZra8&list=WL&index=6&t=0s

    public Transform destination;

    void OnMouseDown()
    {
        if(GetComponent<BoxCollider>())
        {
            GetComponent<BoxCollider>().enabled = false;
        }

        if (GetComponent<MeshCollider>())
        {
            GetComponent<MeshCollider>().enabled = false;
        }

        GetComponent<Rigidbody>().useGravity = false;

        //Move position of object infront to the destination object
        this.transform.position = destination.position;

        this.transform.parent = GameObject.Find("Destination").transform;
    }

    //When mouse is let go object returns to normal
    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;

        if (GetComponent<BoxCollider>())
        {
            GetComponent<BoxCollider>().enabled = true;
        }

        if (GetComponent<MeshCollider>())
        {
            GetComponent<MeshCollider>().enabled = true;
        }
    }
}
