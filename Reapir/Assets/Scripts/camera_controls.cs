using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controls : MonoBehaviour
{
    private GameObject player;

    // still variable can be used to make camera static
    public bool still = false;

    private Vector3 offset = Vector3.back;

    // set still command
    public void setStill(bool b)
    {
        still = b;
    }

    
    void Start()
    {
        player = FindObjectOfType<player_movement>().gameObject;

        if (still == false)
        {
            transform.position = player.transform.position + offset;
        }
    }

    void LateUpdate()
    {
        if (still == false)
        {
            transform.position = player.transform.position + offset;
        }
    }
}
