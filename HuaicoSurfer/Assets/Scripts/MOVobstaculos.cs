using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVobstaculos : MonoBehaviour
{
    Rigidbody rb;
    public float VelocidadMinima = 90f;
    public float VelocidadMaxima = 350f;
    private float NumRandom;

    
    void Start()
    {
         NumRandom = Random.Range(VelocidadMinima, VelocidadMaxima + 1);
        rb = GetComponent<Rigidbody>();
        rb.velocity -= new Vector3(0, 0, NumRandom);
        Debug.Log(NumRandom);
       
    }

    void Update()
    {
        
    }
}
