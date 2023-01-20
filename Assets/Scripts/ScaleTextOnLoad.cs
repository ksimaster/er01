using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScaleTextOnLoad : MonoBehaviour
{
    public float deltaTimeDelay = 0.1f;
    public float deltaFontSize = 10f;
    public void StartObject()
    {
        gameObject.SetActive(true);
        StartCoroutine("RiseText");
    }
    IEnumerator RiseText()
    {

      
        yield return new WaitForSeconds(deltaTimeDelay);
        gameObject.GetComponent<TMP_Text>().fontSize += deltaFontSize;
        yield return new WaitForSeconds(deltaTimeDelay);
        gameObject.GetComponent<TMP_Text>().fontSize += deltaFontSize;
        yield return new WaitForSeconds(deltaTimeDelay);
        gameObject.GetComponent<TMP_Text>().fontSize += deltaFontSize;
       

    }
}
