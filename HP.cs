using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public int maxHP;
    public int currentHP;
    public Slider slider;
    public Gradient gradient;
    public Image fill;
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
        slider.value = 5;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
