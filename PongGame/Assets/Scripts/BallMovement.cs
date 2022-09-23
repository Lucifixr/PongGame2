using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
   private float moveSpeed = 5f;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime); //Bal beweegt
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
           
         // Zorgt ervoor dat de bal weerkaatst wanneer hij een paddle of muur hit.
        }
                
                
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {

            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP2Score();
        }
        if (collision.gameObject.CompareTag("Goal2")) 
        {

            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP1Score();
        }
                
       
    }
    // Reset de ball
    private void ResetBall()
    {
        transform.position = new Vector3(0, 0, -1);
        direction = new Vector3(Random.Range(1f, -1f),Random.Range(1f, -1f), 0);
        direction = direction.normalized;
    }

    


}

