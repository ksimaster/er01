using UnityEngine;
using UnityEngine.EventSystems;


public class ObjectMouseDetector : MonoBehaviour
{
  
    //public GameObject Canvas;
    private void OnMouseEnter()
    {
        gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        gameObject.SetActive(false);
    }

}
