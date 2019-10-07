using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogController : MonoBehaviour
{
    ParticleSystem fogParticles;
    ParticleSystem.ShapeModule shapeModule;

    void Awake()
    {
        fogParticles = GetComponent<ParticleSystem>();
        shapeModule = fogParticles.shape;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FogDecrease()
    {
        shapeModule.radius += 0.25f;
        Debug.Log("Decrease Fog. New Value = " + shapeModule.radius);
    }

    public void FogReset()
    {
        shapeModule.radius = 7;
        Debug.Log("Reset Fog. New Value = " + shapeModule.radius);
    }
}
