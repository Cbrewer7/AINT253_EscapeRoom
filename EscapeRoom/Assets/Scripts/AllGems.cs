using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllGems : MonoBehaviour
{
    public static int sTempGem;
    public static int eTempGem;
    public static int rTempGem;
    private static int allGems;

    public AudioClip audioClip;

    public AudioSource audioSource;

    public GameObject wall;

    private bool allTheGems = false;

    private void Start()
    {
        audioSource.clip = audioClip;

        wall.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        sTempGem = SDetection.numOfGems;
        eTempGem = EDetection.numOfGems;
        rTempGem = RDetection.numOfGems;

        allGems = sTempGem + eTempGem + rTempGem;
        if (allGems == 3)
        {
            allTheGems = true;
        }


        if (allTheGems == true)
        {
            Debug.Log("we got them");

            audioSource.Play();

            //Open Hatch
            wall.GetComponent<MeshRenderer>().enabled = false;

        }
    }
}
