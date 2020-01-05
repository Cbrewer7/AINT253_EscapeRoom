using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllGems : MonoBehaviour
{
    public static int sTempGem;
    public static int eTempGem;
    public static int rTempGem;
    private static int allGems;

    void Update()
    {
        SortGems();
    }

    void SortGems()
    {
        sTempGem = SDetection.numOfGems;
        eTempGem = EDetection.numOfGems;
        rTempGem = RDetection.numOfGems;

        allGems = sTempGem + eTempGem + rTempGem;

        if (allGems == 3)
        {
            Debug.Log("we got them");
            
            //Open Hatch
            GameObject.Find("Wall_Segment").SetActive(false);
            
        }
    }
}
