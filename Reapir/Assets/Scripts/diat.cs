﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diat : MonoBehaviour
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

    public void TriggerDialogue()
    {
        panel.SetActive(true);
        FindObjectOfType<dialogue_manager>().StartDialogue(text);
    }
}