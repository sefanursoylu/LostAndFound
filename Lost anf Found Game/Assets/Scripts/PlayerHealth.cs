using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject WrongPanel;
    private bool isActive = false;
    public int HP = 3;

    void Update()
    {
    //    if((HP == 2) || (HP == 1))
    //    {
    //        isActive = true;
    //    }

    //    if (isActive == true)
    //    {
    //        WrongPanel.SetActive(true);
    //        isActive = false;
    //    }

    //    Debug.Log(HP);
    }

    public void WrongPanelDeactivate()
    {
        WrongPanel.SetActive(false);
    }
}
