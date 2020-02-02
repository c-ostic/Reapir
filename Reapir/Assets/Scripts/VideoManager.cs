using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour
{
    public Camera camera;
    private VideoPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player = camera.GetComponent<VideoPlayer>();
        player.loopPointReached += LoadOverworld;
    }
    
    public void LoadOverworld(VideoPlayer vp)
    {
        SceneManager.LoadScene("Overworld");
    }
}
