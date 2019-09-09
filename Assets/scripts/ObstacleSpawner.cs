using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float minY;
    public float maxY;
    public float distance;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "obstacles")
        {
            float obstacleY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(transform.position.x + distance, obstacleY, 0);
            coll.gameObject.transform.position = spawnPosition;
        }
    }
}
