using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager singolton_ItemManager;
    //������
    [SerializeField] private GameManager basic_Gun;
    private void Start()
    {
        singolton_ItemManager = this;
    }
}
