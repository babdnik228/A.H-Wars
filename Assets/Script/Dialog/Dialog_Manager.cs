using UnityEngine;

public class Dialog_Manager : MonoBehaviour
{
    public static Dialog_Manager dialog_manager_singolton;
    //Bool 
    public bool is_coins_NPS;
    public bool is_gun_NPS;
    private void Start()
    {
        dialog_manager_singolton = this;
    }
}
