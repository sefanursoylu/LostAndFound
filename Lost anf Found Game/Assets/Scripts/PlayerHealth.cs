using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int HP = 3;
    public GameObject[] hp;


    void Start()
    {
        for (var i = 0; i < 3; i++)
        {
            hp = GameObject.FindGameObjectsWithTag("Health");
        }

    }

    void Update()
    {

        if (HP == 2)
        {
            Destroy(hp[0]);
        }

        if (HP == 1)
        {
            Destroy(hp[1]);
        }

        if (HP == 0)
        {
            Destroy(hp[2]);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (HP < 0)
        {
            HP = 0;
        }
    }

}
