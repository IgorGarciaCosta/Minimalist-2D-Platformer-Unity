using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.1f;
    int numOfMovements = 0;
    float speed = 0.3f;
    private bool facingRight = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int moves = 15;

        if (numOfMovements == moves)
            {
                numOfMovements = -1;
                Flip();
                speed = -speed;
                timer = 0;
            }

            //move sideways on timed interval
            timer += Time.deltaTime;
            if (timer > timeToMove && numOfMovements < moves)
            {//if it's enough time stopped, move
                transform.Translate(new Vector3(speed, 0, 0));
                timer = 0;//stutter effect (wait and move, wait and move)
                numOfMovements++;
            }
    }


    void Flip(){
        
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;//get current object scale
        Scaler.x *=-1;//flip in x axis
        transform.localScale = Scaler;
    }
}
