using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterInstantiate : MonoBehaviour
{
    public characterList charList;
    public customerList objectList;
    public GameObject ob;
    public Transform goOB;
    private GameObject obj_;
    private Color oldColor;
    public currentCustomer currOb;
    public GameObject curO;

    void Start()
    {
        for (var i = 0; i < 1; i++)
        {
            ob = Instantiate(charList.characters[Random.Range(0, charList.characters.Count)], transform.position, Quaternion.identity);
            goOB = ob.gameObject.transform.GetChild(0).transform;
            obj_ = Instantiate(objectList.customers[Random.Range(0, objectList.customers.Count)], goOB.position, Quaternion.identity);
            obj_.transform.SetParent(ob.transform);

            
        }

 
        

    }

    void Update()
    {
        
        Destroy(ob, 10);
        
        if (ob == false)
        {
            for (var i = 0; i < 1; i++)
            {
                ob = Instantiate(charList.characters[Random.Range(0, charList.characters.Count)], transform.position, Quaternion.identity);
                goOB = ob.gameObject.transform.GetChild(0).transform;
                obj_ = Instantiate(objectList.customers[Random.Range(0, objectList.customers.Count)], goOB.position, Quaternion.identity);
                obj_.transform.SetParent(ob.transform);

                if (obj_.tag == objectList.customers[i].tag)
                {
                    objectList.customers.Remove(objectList.customers[i]);
                }

            }

        }

        

        oldColor = ob.GetComponent<Renderer>().material.color;
        ob.GetComponent<Renderer>().material.color = Color.Lerp(oldColor, Color.red, Time.deltaTime / 10f);
    }
}
