using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstablishGun : MonoBehaviour
{
    [SerializeField] private Transform point_Spawn;
    [SerializeField] private GameObject object_spawn;
    private void OnTriggerStay(Collider other)
    {
        ItemManager itemManager = other.GetComponent<ItemManager>();
        if(itemManager != null)
        {
            if(ActivGun.singolton_activGun.is_ActivGun == true)
            {
                ItemManager.singolton_ItemManager.basic_Gun.GetComponentInChildren<MeshRenderer>().material.color = Color.green;
                if(Input.GetKeyDown(KeyCode.R))
                {
                    GameObject gun = Instantiate(object_spawn, point_Spawn.position, Quaternion.identity);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ItemManager itemManager = other.GetComponent<ItemManager>();
        if (itemManager != null)
        {
            if (ActivGun.singolton_activGun.is_ActivGun == true)
            {
                ItemManager.singolton_ItemManager.basic_Gun.GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
            }
        }
    }
}
