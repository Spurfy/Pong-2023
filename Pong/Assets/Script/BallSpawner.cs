using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner Instance;

    public Transform spawnPosition;
    public Vector3 direction;
    public GameObject ballPrefab;

    GameObject currentBall;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Call the SpawnBall Method
            SpawnBall();
        }
    }

    public void SpawnBall()
    {
        //Spawns the ball based on my prefab
        currentBall = Instantiate(ballPrefab, spawnPosition.position, transform.rotation, null);

        //Creats a new Vector direction that we will assign to the ball
        float randX = Random.Range(0, 2) * 2 -1;
        float randY = Random.Range(-1.5f, 1.5f);
        Vector3 newDirection = new Vector3(randX, randY, 0);

        //Apply the new direction to the ball
        currentBall.GetComponent<Ball>().direction = newDirection;
    }
}
