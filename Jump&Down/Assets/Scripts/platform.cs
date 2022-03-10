using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    private Vector3 movement;
    private GameObject topline;
    public float speed;
    
    void Start()
    {
        movement.y = speed;
        topline=GameObject.Find("Topline");
    }

    void Update()
    {
        moveplatform();
    }

    void moveplatform()
    {
        transform.position += movement*Time.deltaTime;
        if (transform.position.y >= topline.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
