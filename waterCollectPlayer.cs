using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterCollectPlayer : MonoBehaviour
{
    public Animator animator;
    public bool touchingWater;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (touchingWater == true)
            {
                animator.SetTrigger("Water");


            }
        }
    }


}