using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcCollision : MonoBehaviour
{

    public dialogue text;
    public GameObject panel;

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
        TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        Debug.Log("have been clicked");
        panel.SetActive(true);
        FindObjectOfType<dialogueManager>().StartDialogue(text);
    }
}
