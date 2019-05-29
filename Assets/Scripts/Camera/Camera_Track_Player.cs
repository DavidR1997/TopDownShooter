﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Track_Player : MonoBehaviour
{
    [Header("Follow")]
    public Transform target;
    public Camera trackingCamera;
    public Vector3 offset;
    [Header("Smoothing")]
    public float smoothing = 0.2f;
    public Vector3 velocity = Vector3.zero;
    void Start()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
        offset = transform.position - target.position;
        
        trackingCamera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
        transform.LookAt(target.position);
        //Vector3 targetPos = target.position;
        //targetPos.y = transform.position.y;
        //smooths camera movement
        //transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothing);
    }
    private void FixedUpdate()
    {

    }
}
