using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectBehaviour : MonoBehaviour
{
    public GameObject currentCustomer;
    public currentCustomer customerChecker;
    public PlayerHealth HP;

    public void Update()
    {
        currentCustomer = GameObject.FindGameObjectWithTag("Customer");
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && (gameObject.tag == customerChecker.currentTag))
        {
            Debug.Log("Correct Object!");
            Destroy(currentCustomer);
            Destroy(gameObject);
        } 
        
        if (Input.GetMouseButtonDown(0) && (gameObject.tag != customerChecker.currentTag))
        {
            Debug.Log("Incorrect Object!");
            HP.HP--;
        }
    }

}
