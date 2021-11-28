using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRB;
    public float Speed;
    public GameObject head;
    
    
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
        head.transform.position = transform.position;               // to have head stay on the top without moving 
    }

    void MovePlayer()
    {
        float Hmovement = Input.GetAxis("Horizontal");        
        float Vmovement = Input.GetAxis("Vertical");

        Vector3 BodyMove = new Vector3(Hmovement, 0f, Vmovement);       // WASD movement for body
        playerRB.AddForce(BodyMove * 10);                    

        if (Hmovement == 0 && Vmovement == 0)              // this condition will set the movement to zero if you leave the key 
        {
            playerRB.angularVelocity = Vector3.zero;     
        }
    }

}
