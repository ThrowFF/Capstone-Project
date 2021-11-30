using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Rigidbody playerRB;
    public float Speed;
    public GameObject Turret;
    public Vector3 offset;



    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();

    }
    private void Update()
    {
        Turret.transform.position = transform.position + offset;               // to have head stay on the top without moving 
        
    }

    void MovePlayer()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 bodyMove = new Vector3(Horizontal, 0f, Vertical);       // WASD movement for body
        playerRB.AddForce(bodyMove * 10);

      if (Horizontal == 0 && Vertical == 0)              // this condition will set the movement to zero if you leave the key 
         {
           playerRB.angularVelocity = Vector3.zero;
         }
    }
}