using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float JumpH = 5;
    public float gravityModifier;

    private bool isGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            playerRb.AddForce(Vector3.up * JumpH, ForceMode.Impulse);
            isGround = false;
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        isGround = true;
    }
}
