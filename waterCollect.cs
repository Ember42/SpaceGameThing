using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterCollect : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Player").GetComponent<waterCollectPlayer>().touchingWater = true;


    }

    void OnTriggerExit2D(Collider2D collision)
    {

        GameObject.Find("Player").GetComponent<waterCollectPlayer>().touchingWater = false;

    }
}
