using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.1f;
    int numOfMovements = 0;
    float speed = 0.3f;
    // Start is called before the first frame update
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
                speed = -speed;//make the movement other way
                timer = 0;
            }

            //move sideways on timed interval
            timer += Time.deltaTime;
            if (timer > timeToMove && numOfMovements < moves)
            {//if it's enough time stopped, move
                transform.Translate(new Vector3(0, speed, 0));
                timer = 0;//stutter effect (wait and move, wait and move)
                numOfMovements++;
            }
    }
}
