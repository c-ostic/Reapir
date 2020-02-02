using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public static string startPoint;

    private void Start()
    {
        Debug.Log("Projector Base " + GlobalVars.projectorBase);
        Debug.Log("Projector Film " + GlobalVars.projectorFilm);
        Debug.Log("Projector Reel " + GlobalVars.projectorReel);
        Debug.Log("Projector Lens " + GlobalVars.projectorLens);
    }

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public string getStartPoint()
    {
        return startPoint;
    }

    public void setStartPoint(string newStartPoint)
    {
        startPoint = newStartPoint;
    }
}
