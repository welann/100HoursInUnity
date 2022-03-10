using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linerender : MonoBehaviour
{
    private LineRenderer line;
    public Transform startpoint;
    public Transform endpoint;

    void Start()
    {
        line=GetComponent<LineRenderer>();
    }

    void Update()
    {
        // line.SetPosition(0, new Vector3(startpoint.position.x,startpoint.position.y,0));
        // line.SetPosition(1, new Vector3(endpoint.position.x, endpoint.position.y, 0));
        line.SetPosition(0,startpoint.position);
        line.SetPosition(1,endpoint.position);
    }
}
