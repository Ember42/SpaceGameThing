using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdValue : MonoBehaviour
{
    public Animator animator;
    public float birdValue;
    void Start()
    {
        StartCoroutine(generateBirdValue());
    }
    IEnumerator generateBirdValue()
    {
        yield return new WaitForSeconds(1);
        birdValue = Random.Range(1, 100);
        animator.SetFloat("bird", birdValue);
        StartCoroutine(generateBirdValue());
    }
#change
}
