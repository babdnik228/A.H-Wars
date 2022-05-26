using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFor : MonoBehaviour
{
    private string textString;
    public Text textGameObject;
    private void Awake()
    {
        textString = textGameObject.text;
        textGameObject.text = "";
        StartCoroutine(CorTextFor());
    }
    IEnumerator CorTextFor()
    {
        foreach (char abs in textString)
        {
            textGameObject.text += abs;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
