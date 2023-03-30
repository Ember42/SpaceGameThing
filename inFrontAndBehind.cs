using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inFrontAndBehind : MonoBehaviour
{
    public string objects;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find(objects).GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Layer");
        }
            

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find(objects).GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");
        }
           

    }
}