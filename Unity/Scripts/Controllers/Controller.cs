﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MapGrid.CreateMapGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Sprite[] sprites;
}
