﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashFX : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DashShow()
    {
        spriteRenderer.enabled = true;
    }

    public void DashHide()
    {
        spriteRenderer.enabled = false;
    }
}
