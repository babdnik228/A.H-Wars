using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Button_Help : MonoBehaviour
{
    public  GameObject button_helper;

    private void OnTriggerEnter(Collider other)
    {
        HeroManager heroManager = other.GetComponent<HeroManager>();
        if(heroManager != null)
        {
            button_helper.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        HeroManager heroManager = other.GetComponent<HeroManager>();
        if (heroManager != null)
        {
            button_helper.SetActive(false);
        }
    }
}
