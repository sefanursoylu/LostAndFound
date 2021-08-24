using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterInstantiate : MonoBehaviour
{
    public characterList charList;
    public GameObject objectList;
    public GameObject ob;

    void Start()
    {
        for (var i = 0; i < 1; i++)
        {
            ob = Instantiate(charList.characters[Random.Range(0, charList.characters.Count)], transform.position, Quaternion.identity);
            //ob.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
        }
    }
}
