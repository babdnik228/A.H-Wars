using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evelator : MonoBehaviour
{
    [SerializeField] private GameObject Blac_BG;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject finish_point;
    private void OnTriggerStay(Collider other)
    {
        HeroManager heroManager = other.GetComponent<HeroManager>();
        if(heroManager != null)
        {
            if(Input.GetKeyDown(KeyCode.Z))
            {
                StartCoroutine(Cor_Evelator());
            }
        }
    }
    private IEnumerator Cor_Evelator()
    { 
        Blac_BG.SetActive(true);
        yield return new WaitForSeconds(2f);
        player.transform.position = finish_point.transform.position;
        yield return new WaitForSeconds(2f);
        Blac_BG.SetActive(false);
    }

}
