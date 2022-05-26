using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsFerma : MonoBehaviour
{
    [SerializeField] private GameObject PanelCoins;
    [SerializeField] private GameObject Camera_Coins;
    [SerializeField] private GameObject Camera_Main;
    [SerializeField] private GameObject point_transform;
    [SerializeField] private GameObject bg_blac;
    [SerializeField] private GameObject player;
    [SerializeField] private UI_Button_Help button_Help;
    [SerializeField] private Dialog_Activator dialog;

    private void OnTriggerStay(Collider other)
    {
        HeroManager heroManager = other.GetComponent<HeroManager>();
        if (heroManager != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialog.Dialog_Coins_One_Text();
                button_Help.button_helper.SetActive(false);
                StartCoroutine(COR_IByeGun());
            }
        }
    }
    public void ExitPanel()
    {
        PanelCoins.SetActive(false);
        Camera_Coins.SetActive(false);
        Camera_Main.SetActive(true);
        InputLogic.inputLogic_singolton._speedInput = 5;
    }
    private IEnumerator COR_IByeGun()
    {
        bg_blac.SetActive(true);
        InputLogic.inputLogic_singolton._speedInput = 0;
        yield return new WaitForSeconds(4f);
        player.transform.position = point_transform.transform.position;
        PanelCoins.SetActive(true);
        bg_blac.SetActive(false);
        Camera_Main.SetActive(false);
        Camera_Coins.SetActive(true);
    }
}
