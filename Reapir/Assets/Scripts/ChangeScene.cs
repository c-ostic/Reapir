using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;

    public bool active;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(active)
            SceneManager.LoadScene(sceneName);
    }
}
