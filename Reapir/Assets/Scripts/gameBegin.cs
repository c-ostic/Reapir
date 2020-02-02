using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameBegin : MonoBehaviour
{
    
    public void changemenuscene(string scenename)
    {
    	Application.LoadLevel(scenename);
    }

}
