using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    public static HeroManager singolton_HeroManager;

    public int coins = 0;
    public int emerald;
    public int healthPlayer;
    public int healthMaxPlayer;
    void Start()
    {
        singolton_HeroManager = this;
    }
}

