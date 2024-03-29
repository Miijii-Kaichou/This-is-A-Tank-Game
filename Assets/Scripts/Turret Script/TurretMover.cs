﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMover : MonoBehaviour
{
    public Transform tf; //Turret transform
    public TankData data; //And our tank data

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>(); //Grab our transform
        data = GetComponentInParent<TankData>(); //Grab the tank data that is located in our parent gameobject
    }

    // Update is called once per frame
    public void Rotate(float direction)
    {
        //Actual turret movement
        data.turrettf.Rotate(new Vector3(0, direction * data.turretRotateSpeed * Time.deltaTime, 0));
    }
}