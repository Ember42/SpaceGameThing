using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed;
    public string goTo;
    public Animator animator;
    private Vector3 direction;
    public bool freeze;
    private static bool playerExists;
    public float horizontal2;
    public float vertical2;


    void Start()
    {

        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }


    // Update is called once per frame
    private void FixedUpdate()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector3(horizontal, vertical, 0);
        AnimateMovement(direction);
        if (freeze != true)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void AnimateMovement(Vector3 direction)
    {
        if(animator != null)
        {
            if(direction.magnitude > 0)
            {
                animator.SetBool("isMoving", true);

                animator.SetFloat("horizontal", direction.x);
                animator.SetFloat("vertical", direction.y);
                horizontal2 = Input.GetAxisRaw("Horizontal");
                vertical2 = Input.GetAxisRaw("Vertical");
            }
            else
            {
                animator.SetBool("isMoving", false);
            }
        }
    }

}
