﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Material {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void TakeMaterial()
    {
        MaterialManager.Instance.AddMaterial(this);
    }
}
