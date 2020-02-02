using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public string pieceName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collecting Item");
        GlobalVars.setTrue(pieceName);
        gameObject.SetActive(false);
    }
}
