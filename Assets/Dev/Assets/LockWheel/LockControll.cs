using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LockControll : MonoBehaviour
{

    public GameObject door;
    private int[] result, correctCombination;
    private Animation anim;
   // public Animator animator;


    void Start()
    {
        result = new int[] { 0, 0, 0 };
        correctCombination = new int[] { 7, 5, 9 };
        Rotate.Rotated += CheckResult;
        anim = door.GetComponent<Animation>();
        //animator = door.GetComponent<Animator>();
    }

    private void CheckResult(string wheelName)
    {
        
        switch (wheelName)
        {
            case "Wheel1":
                result[0] = ++result[0] % 10;
                break;
            case "Wheel2":
                result[1] = ++result[1] % 10;
                break;
            case "Wheel3":
                result[2] = ++result[2] % 10;
                break;
        }
        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
        {
                FindObjectOfType<AudioManager>().Play("Lock_Open");
                FindObjectOfType<AudioManager>().Play("Door_Open");
            try
            {
                //door.GetComponent<Animation>().Play("openDoor");
                anim.Play("openDoor");

                //animator.SetTrigger("Open");
            }
            catch
            {
                Debug.Log("Ошибка в проигрывании анимации openDoor");
            }

            
        }
    }
}
