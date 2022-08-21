﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(50, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - plane.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
        //transform.position = new Vector3(plane.transform.position.x, plane.transform.position.y, 8);    

    }
}