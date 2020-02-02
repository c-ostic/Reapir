using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator anim;
    public float hf = 0.0f;
    public float vf = 0.0f;
    Vector2 movement;

    public static string startPoint;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
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

        hf = movement.x > 0.01f ? movement.x : movement.x < -0.01f ? 1 : 0;
        vf = movement.y > 0.01f ? movement.y : movement.y < -0.01f ? 1 : 0;
        if (movement.x < -0.01f)
        {
            this.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        anim.SetFloat("Horizontal", hf);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", vf);
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
