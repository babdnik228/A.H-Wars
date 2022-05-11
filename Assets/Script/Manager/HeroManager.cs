using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    public static HeroManager singolton_HeroManager;

    public static int coins;
    public static int emerald;
    private void Start()
    {
        singolton_HeroManager = this;
    }

}
