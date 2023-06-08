using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moverse : MonoBehaviour
{

    public int VelocidadHorizontal;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float MovimientoHorizontal = Input.GetAxis("Horizontal");


        rb.velocity = new Vector3(MovimientoHorizontal * VelocidadHorizontal, 0,0);

        if (MovimientoHorizontal != Input.GetAxis("Horizontal"))
        {
            rb.velocity = new Vector3(0, 0, 0);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstaculo"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
