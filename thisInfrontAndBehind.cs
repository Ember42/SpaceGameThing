using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisInfrontAndBehind : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            this.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Layer");
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            this.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");
        }


    }
}