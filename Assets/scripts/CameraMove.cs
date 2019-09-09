using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform birdtransform;
    Vector3 range;
    // Start is called before the first frame update
    void Awake()
    {
        range = transform.position - birdtransform.position;
    }

    // Update is called once per frame
     void FixedUpdate()
    {
        transform.position = new Vector3(range.x + birdtransform.position.x, transform.position.y, range.z + birdtransform.position.z);
    }
}
