using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivGun : MonoBehaviour
{
    public static ActivGun singolton_activGun;
    public bool is_ActivGun;
    private void Start()
    {
        singolton_activGun = this;
    }
    private void Update()
    {
        Gun_Indication();
    }
    public void Gun_Indication()
    {
        if(ItemManager.singolton_ItemManager.is_One_Slot == true)
        {
            if(Input.GetKey(KeyCode.Q))
            {
                is_ActivGun = true;
                ItemManager.singolton_ItemManager.basic_Gun.SetActive(true);
                ItemManager.singolton_ItemManager.basic_Gun.GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
            }
            else if(Input.GetKeyUp(KeyCode.Q))
            {
                is_ActivGun = false;
                ItemManager.singolton_ItemManager.basic_Gun.SetActive(false);
            }
        }
    }
}
