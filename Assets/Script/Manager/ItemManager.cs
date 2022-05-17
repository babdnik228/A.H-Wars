using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager singolton_ItemManager;
    //Орудия
    public GameObject basic_Gun;
    //Булевые кнопки
    public bool is_One_Slot;
    //Число орудий
    public int gun_Classic;


    private void Start()
    {
        singolton_ItemManager = this;
    }
    private void Update()
    {
        Slot_Existence();
    }
    public void Slot_Existence()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
          is_One_Slot = true; 
        }
        else if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            is_One_Slot = false;
        }
    }

}
