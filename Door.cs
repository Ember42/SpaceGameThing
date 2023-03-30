using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    public bool touchingDoor;
    public bool open;
    public string doorStop;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (touchingDoor == true)
            {
                if (open == false)
                {
                    animator.SetBool("DoorOpen", true);
                    open = true;
                    GameObject.Find(doorStop).GetComponent<EdgeCollider2D>().enabled = false;
                }
                else
                {
                    animator.SetBool("DoorOpen", false);
                    open = false;
                    GameObject.Find(doorStop).GetComponent<EdgeCollider2D>().enabled = true;
                }

            }

        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        touchingDoor = true;

    }

    void OnTriggerExit2D(Collider2D collision)
    {

        touchingDoor = false;

    }
}
