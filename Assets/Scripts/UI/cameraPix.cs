﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPix : MonoBehaviour
{
    [SerializeField]
    private Transform characterBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = characterBody.position + new Vector3(0, 2, 0) ;
    }
}