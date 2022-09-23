using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public int playerNumber = 2;
    public float MoveSpeed = 3.0f; 
    // Update is called once per frame
    void Update()
    {
        if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Paddle2") * MoveSpeed * Time.deltaTime, 0));
    
    }   }
}
