using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathPitCollision : MonoBehaviour
{
    
    public string sceneName;

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
        Application.LoadLevel(sceneName);
    }


}
