using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    public static HeroManager singolton_HeroManager;

    public  int coins = 25;
    public  int emerald;
    private void Start()
    {
        singolton_HeroManager = this;
    }

}
