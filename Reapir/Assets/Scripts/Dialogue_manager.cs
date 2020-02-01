﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue_manager : MonoBehaviour
{
    public Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(dialogue text)
    {
        Debug.Log("Starting Conversation with" + text.name);
    }
}
