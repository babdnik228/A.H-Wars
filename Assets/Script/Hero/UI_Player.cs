using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Player : MonoBehaviour
{
    public HeroManager heroManager;
    public Slider health;
    public Slider healthMax;
    private void Update()
    {
        health.value = heroManager.healthPlayer;
        healthMax.maxValue = heroManager.healthMaxPlayer;
    }
}
