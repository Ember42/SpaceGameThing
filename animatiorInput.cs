using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatiorInput : MonoBehaviour
{
    public Animator animator;
    public bool Trigger;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Trigger == true)
            {
                animator.SetTrigger("Input");
            }
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        Trigger = true;

    }

    void OnTriggerExit2D(Collider2D collision)
    {

        Trigger = false;

    }
}
