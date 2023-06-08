using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVescenario : MonoBehaviour
{
    public int VelocidadEscenario = 100;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity -= new Vector3(0, 0, VelocidadEscenario);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
   
}
