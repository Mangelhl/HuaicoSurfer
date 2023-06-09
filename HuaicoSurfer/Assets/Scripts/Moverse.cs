using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moverse : MonoBehaviour
{
    public ScoreController scoreController;
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
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Obstaculo"))
        {
            SceneManager.LoadScene(1);
        }

        if (col.gameObject.CompareTag("Civil"))
        {
            scoreController.UpdateScore(1);
            Destroy(col.gameObject);
        }

    }
    
}
