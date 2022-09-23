using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerNumber = 1;
    public float MoveSpeed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetAxis("Player1"));
        if (playerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Paddle1") * MoveSpeed * Time.deltaTime, 0));

        }

    }
}

      
        
