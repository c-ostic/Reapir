using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapCloneCollision3 : MonoBehaviour
{
    public GameObject clone;
    public GameObject clone2;
    public GameObject clone3;
    public GameObject player;
    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        clone.SetActive(true);
        clone2.SetActive(true);
        clone3.SetActive(true);
        player.SetActive(false);
        self.SetActive(false);

    }


}
