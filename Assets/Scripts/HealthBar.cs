using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void setHealth(float val)
    {
        slider.value = val;
        fill.color = gradient.Evaluate(val);
    }
}