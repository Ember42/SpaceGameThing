using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueSlime : MonoBehaviour
{
    public Animator animator;
    public int number;
    void Start()
    {
        StartCoroutine(generateNumber());
    }
    #change
    IEnumerator generateNumber()
    {
        yield return new WaitForSeconds(1);

        number = Random.Range(1, 100);
        print(number);
        if (number <= 20)
        {
            animator.SetTrigger("bounce");
        }
        StartCoroutine(generateNumber());
    }
}
