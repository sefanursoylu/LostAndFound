using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectBehaviour : MonoBehaviour
{
    public GameObject customer;

   public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && (gameObject.tag == customer.tag))
        {
            Debug.Log("Correct Object!");
        } 
        
        if (Input.GetMouseButtonDown(0) && (gameObject.tag != customer.tag))
        {
            Debug.Log("Incorrect Object!");
        }
    }

}
