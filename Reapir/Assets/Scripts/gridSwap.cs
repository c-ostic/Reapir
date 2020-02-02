using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridSwap : MonoBehaviour
{

    public GameObject grid1;
    public GameObject grid2;
    public bool on;

    // Start is called before the first frame update
    void Start()
    {
        on = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (on == false)
        {
            Debug.Log("Collision");
            grid1.SetActive(true);
            grid2.SetActive(false);
            on = true;
        }
        else
        {
            Debug.Log("Collision");
            grid1.SetActive(false);
            grid2.SetActive(true);
            on = false;
        }
    }
}
