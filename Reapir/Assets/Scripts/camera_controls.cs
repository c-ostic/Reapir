using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controls : MonoBehaviour
{
    public GameObject player;

    // still variable can be used to make camera static
    public bool still = false;

    private Vector3 offset;

    // set still command
    public void setStill(bool b)
    {
        still = b;
    }

    void Start()
    {
        if (still == false)
        {
            offset = transform.position - player.transform.position;
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
