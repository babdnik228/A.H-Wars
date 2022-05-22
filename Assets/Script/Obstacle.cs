using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        HeroManager heroManager = other.GetComponent<HeroManager>();
        if(heroManager != null)
        {
            heroManager.healthPlayer--;
        }
    }
}
