using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyAttacks : MonoBehaviour
{
    public Animator animator;
    public int damageTaken;
    public int maxHP;
    public int currentHP;
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public GameObject thisEnemy;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = maxHP;
        slider.value = currentHP;
        fill.color = gradient.Evaluate(1f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        slider.value = currentHP;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        if (currentHP <= 0)
        {
            StartCoroutine(die());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemyHitZone"))
        {
            damageTaken = GameObject.Find("Player").GetComponent<attack>().damage;
            currentHP = currentHP - damageTaken;
        }
    }
    IEnumerator die()
    {
        animator.SetTrigger("die");
        yield return new WaitForSeconds(0.3f);
        Destroy(thisEnemy);
    }
}
