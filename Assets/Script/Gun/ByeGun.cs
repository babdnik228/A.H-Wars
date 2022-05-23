using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeGun : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject Camera_ByeGun;
    [SerializeField] private GameObject Camera_Main;
    [SerializeField] private GameObject point_transform;
    [SerializeField] private GameObject bg_blac;
    [SerializeField] private GameObject player;

    private void OnTriggerStay(Collider other)
    {
        HeroManager heroManager = other.GetComponent<HeroManager>();
        if(heroManager != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(COR_IByeGun());
            }
        }
    }
    public void ExitPanel()
    {
        Panel.SetActive(false);
        Camera_ByeGun.SetActive(false);
        Camera_Main.SetActive(true);
        InputLogic.inputLogic_singolton._speedInput = 5;
    }
    public void BuyGunClassicButton()
    {
        if(HeroManager.singolton_HeroManager.coins >= 20)
        {
            HeroManager.singolton_HeroManager.coins -= 20;
            ItemManager.singolton_ItemManager.gun_Classic++;
        }
    }
    private IEnumerator COR_IByeGun()
    {
        bg_blac.SetActive(true);
        InputLogic.inputLogic_singolton._speedInput = 0;
        yield return new WaitForSeconds(4f);
        player.transform.position = point_transform.transform.position;
        Panel.SetActive(true);
        bg_blac.SetActive(false);
        Camera_Main.SetActive(false);
        Camera_ByeGun.SetActive(true);
    }
}
