using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Prefab for Instantiating bombs
    public GameObject bombPrefab;

    //Speed at which the Enemy moves
    public float speed = 1f;

    //Distance where enemy turns around
    public float leftAndRightEdge = 10f;

    //Chance that the enemy will change directions
    public float chanceToChangeDirections = 0.1f;

    //Rate at which bombs will be instantiated
    public float secondsBetweenBombDrops = 0.5f;

    void Start()
    {
        //Dropping bombs every second 
    }

    // Update is called once per frame
    void Update()
    {
        //Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position=pos;
        //Changing direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move right 
        }else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //move left
        }else if (Random.value < chanceToChangeDirections) 
        {
            speed *= -1;//Change direction
        }
    }
}
