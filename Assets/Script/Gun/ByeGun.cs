using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeGun : MonoBehaviour
{
    [SerializeField] private GameObject Panel;

    private void OnTriggerStay(Collider other)
    {
        HeroManager heroManager = other.GetComponent<HeroManager>();
        if(heroManager != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Panel.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        HeroManager heroManager = other.GetComponent<HeroManager>();
        if (heroManager != null)
        {
                Panel.SetActive(false);
        }
    }
    public void ExitPanel()
    {
        Panel.SetActive(false);
    }
}