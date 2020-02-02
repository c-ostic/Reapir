using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchReveal : MonoBehaviour
{
    public GameObject grid1;
    public GameObject grid2;
    public bool on;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= 1;
        }
        else if (grid1.active != false)
        {
            grid1.SetActive(true);
            grid2.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
            grid1.SetActive(false);
            grid2.SetActive(true);
            //on = true;
            time = 500;
       
    }
}
