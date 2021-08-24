using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentCustomer : MonoBehaviour
{
    public GameObject currentCust;
    public GameObject currentObj;
    public string currentTag;

    void Update()
    {
        currentCust = GameObject.FindGameObjectWithTag("Customer");
        currentObj = currentCust.transform.GetChild(1).gameObject;
        currentTag = currentObj.tag;
    }
}
