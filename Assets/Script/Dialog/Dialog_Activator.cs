using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Dialog_Activator : MonoBehaviour
{
    
    //Gun N.P.S
    [SerializeField] private GameObject text_NPS_gun;
    [SerializeField] private GameObject audio_NPS_gun;

    //Gun Logic
    public void Dialog_Gun_One_Text()
    {
        if(Dialog_Manager.dialog_manager_singolton.is_gun_NPS == true)
        {
            StartCoroutine(COR_Dialog_Gun());
        }
    }
    IEnumerator COR_Dialog_Gun()
    {
        yield return new WaitForSeconds(5f);
        text_NPS_gun.SetActive(true);
        audio_NPS_gun.SetActive(true);
        yield return new WaitForSeconds(2f);
        Dialog_Manager.dialog_manager_singolton.is_gun_NPS = false;
        yield return new WaitForSeconds(4f);
        text_NPS_gun.SetActive(false);
        audio_NPS_gun.SetActive(false);
    }
}
