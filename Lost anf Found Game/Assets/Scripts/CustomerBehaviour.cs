using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehaviour : MonoBehaviour
{
    public List<GameObject> Customers;
    public List<GameObject> Objects;

    private GameObject currentCust;
    private GameObject currentObj;
    private Transform currentTrans;

    private Color currentCol;

    public float Timer = 10f;

    private bool canSpawn = true;

    public PlayerHealth playerHP;

    public void Start()
    {
        for (var i = 0; i < 1; i++)
        {
            currentCust = Instantiate(Customers[Random.Range(0, Customers.Count)], transform.position, Quaternion.identity);
            currentTrans = currentCust.transform.GetChild(0).transform;
            currentObj = Instantiate(Objects[Random.Range(0, Objects.Count)], currentTrans.position, Quaternion.identity);
            currentObj.transform.SetParent(currentCust.transform);
        }

        for (var i = 0; i < Objects.Count; i++)
        {
            if (currentObj.tag == Objects[i].tag)
            {
                Objects.Remove(Objects[i]);
            }
        }
    }

    public void Update()
    {
        Timer -= Time.deltaTime;

        if (canSpawn == true)
        {
            if ((Timer <= 0f) || (currentCust == false))
            {

                if (Timer <= 0)
                {
                    playerHP.HP--;
                }

                Destroy(currentCust);

                for (var i = 0; i < 1; i++)
                {
                    currentCust = Instantiate(Customers[Random.Range(0, Customers.Count)], transform.position, Quaternion.identity);
                    currentTrans = currentCust.transform.GetChild(0).transform;
                    currentObj = Instantiate(Objects[Random.Range(0, Objects.Count)], currentTrans.position, Quaternion.identity);
                    currentObj.transform.SetParent(currentCust.transform);
                }

                for (var i = 0; i < Objects.Count; i++)
                {
                    if(currentObj.tag == Objects[i].tag)
                    {
                        Objects.Remove(Objects[i]);
                    }
                }

                Timer = 10f;

            }

        }

        if (Objects.Count == 0)
        {
            canSpawn = false;
        }

        currentCol = currentCust.GetComponent<Renderer>().material.color;
        currentCust.GetComponent<Renderer>().material.color = Color.Lerp(currentCol, Color.red, Time.deltaTime / 10f);

    }

}
