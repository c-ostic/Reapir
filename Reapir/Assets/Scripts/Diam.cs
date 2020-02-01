using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diam : MonoBehaviour
{
    public Queue<string> sentences;

    public Text nameText;
    public Text dialogueText;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(dialogue text)
    {
        //Debug.Log("Starting Conversation with" + text.name);

        nameText.text = text.name;

        sentences.Clear();

        panel.SetActive(true);

        foreach (string sentence in text.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);
    }

    public void EndDialogue()
    {
        Debug.Log("End of conversation");
        panel.SetActive(false);
    }
}



