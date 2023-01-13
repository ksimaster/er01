using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class History_Papper1 : MonoBehaviour
{
    public GameObject history_paper1;
    public GameObject player;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        //if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "History1")
                {
                    FindObjectOfType<AudioManager>().Play("Paper");
                    history_paper1.gameObject.SetActive(!history_paper1.gameObject.activeSelf);
                    player.GetComponent<Move>().enabled = !player.GetComponent<Move>().enabled;

                }
            }
        }
    }
}
