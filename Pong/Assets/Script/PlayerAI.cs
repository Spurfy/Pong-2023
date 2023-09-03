using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{

    public Paddle paddle;
    Ball currentBall;
    public float distanceBuffer;

    // Update is called once per frame
    void Update()
    {
        if (currentBall == null)
        {
            FindBall();
        }
        else
        {
            FollowBall();
        }
    }

    void TrashTalk()
    {
        Debug.Log("EZ FFS");
    }

    void FindBall()
    {
        if (currentBall == null)
        {
            currentBall = FindObjectOfType<Ball>();
        }

    }

    void FollowBall()
    {
        if(currentBall.transform.position.y > paddle.transform.position.y)
        {
            paddle.MoveUp();
        }
        else if(currentBall.transform.position.y < paddle.transform.position.y)
        {
            paddle.MoveDown();
        }
    }
}
