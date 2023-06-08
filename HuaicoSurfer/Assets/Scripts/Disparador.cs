using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject objetoInstanciado;
    MOVescenario Mo;
    public int distanciaRecorrida;

    // Start is called before the first frame update
    void Start()
    {
        Mo = objetoInstanciado.GetComponent<MOVescenario>();
      
    }

    // Update is called once per frame
    void Update()
    {
       
            StartCoroutine(Reset());
        transform.position -= new Vector3(0, 0, Mo.VelocidadEscenario * Time.deltaTime);
        float posicionZ = transform.localPosition.z;
        int distancia = Mathf.CeilToInt(posicionZ);
        distanciaRecorrida = Mathf.Abs(distancia);
    }
    void Dispara()
    {
        objetoInstanciado = Instantiate(objetoInstanciado);
        objetoInstanciado.transform.position = new Vector3(0, -1, transform.position.z + 85f);
    }
    IEnumerator Reset()
    {
        while(distanciaRecorrida >= 85f)
        {
            distanciaRecorrida = 0;
            transform.localPosition = new Vector3(0, 0, 0);
            Dispara();
            yield return new WaitForSeconds(1);
        }
    }
     
  
}
