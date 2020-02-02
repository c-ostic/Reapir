using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManagerBoatHouse : MonoBehaviour
{
    public Camera camera;
    private VideoPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player = camera.GetComponent<VideoPlayer>();
        player.loopPointReached += QuitGame;
    }

    public void QuitGame(VideoPlayer vp)
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
