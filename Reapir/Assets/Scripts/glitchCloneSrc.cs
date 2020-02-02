using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glitchCloneSrc : MonoBehaviour
{
    public GameObject clone;
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
        self.SetActive(false);
        
    }


}
