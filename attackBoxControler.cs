using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackBoxControler : StateMachineBehaviour
{
    public float horizontal;
    public float vertical;
    private Vector3 direction;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state



    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}
    void OnStateUpdate()
    {
        horizontal = GameObject.Find("Player").GetComponent<Moving>().horizontal2;
        vertical = GameObject.Find("Player").GetComponent<Moving>().vertical2;

        if (vertical == 1)
        {
            GameObject.Find("playerAttackUp").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("playerAttackDown").GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("playerAttackRight").GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("playerAttackLeft").GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            if (vertical == -1)
            {
                GameObject.Find("playerAttackDown").GetComponent<BoxCollider2D>().enabled = true;
                GameObject.Find("playerAttackUp").GetComponent<BoxCollider2D>().enabled = false;
                GameObject.Find("playerAttackRight").GetComponent<BoxCollider2D>().enabled = false;
                GameObject.Find("playerAttackLeft").GetComponent<BoxCollider2D>().enabled = false;
            }
            else
            {
                if (horizontal == 1)
                {
                    GameObject.Find("playerAttackRight").GetComponent<BoxCollider2D>().enabled = true;
                    GameObject.Find("playerAttackDown").GetComponent<BoxCollider2D>().enabled = false;
                    GameObject.Find("playerAttackUp").GetComponent<BoxCollider2D>().enabled = false;
                    GameObject.Find("playerAttackLeft").GetComponent<BoxCollider2D>().enabled = false;
                }
                else
                {
                    if (horizontal == -1)
                    {
                        GameObject.Find("playerAttackLeft").GetComponent<BoxCollider2D>().enabled = true;
                        GameObject.Find("playerAttackUp").GetComponent<BoxCollider2D>().enabled = false;
                        GameObject.Find("playerAttackDown").GetComponent<BoxCollider2D>().enabled = false;
                        GameObject.Find("playerAttackRight").GetComponent<BoxCollider2D>().enabled = false;
                    }
                }
            }
        }
        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        //{
        //    
        //}


    }
    //}
    void OnStateExit()
    {
        GameObject.Find("playerAttackUp").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("playerAttackDown").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("playerAttackRight").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("playerAttackLeft").GetComponent<BoxCollider2D>().enabled = false;
    }
}
