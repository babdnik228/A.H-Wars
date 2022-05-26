using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Mous_Text : MonoBehaviour
{
    [SerializeField] private GameObject text_activate;
    [SerializeField] private GameObject[] text_deactivate;

    public void ButtonText()
    {
        text_activate.SetActive(true);
        for (int i = 0; i < text_deactivate.Length; i++)
        {
            text_deactivate[i].SetActive(false);
        }
    }

}
