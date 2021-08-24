using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectBehaviour : MonoBehaviour
{
    private GameObject currentCustomer;
    public currentCustomer customerChecker;
    public PlayerHealth HP;

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && (gameObject.tag == customerChecker.currentTag))
        {
            Debug.Log("Correct Object!");
            Destroy(gameObject);
        } 
        
        if (Input.GetMouseButtonDown(0) && (gameObject.tag != customerChecker.currentTag))
        {
            Debug.Log("Incorrect Object!");
            HP.HP--;
        }
    }

}
