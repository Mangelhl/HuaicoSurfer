using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarInstancias : MonoBehaviour
{
    public GameObject[] prefabs;
    public int cantidadInstancias;
     DividirPlano plano; 
    public int Tiempo;
    public int TiempoInicio;
    public bool paraObstaculos = true;

    void Start()
    {
        plano = GetComponent<DividirPlano>();
        if(paraObstaculos)
        {
            InvokeRepeating("GenerarInstanciasAleatorias", TiempoInicio, Tiempo);
        }
        
        else
        {
            GenerarInstanciasAleatorias();
        }
    }

    void GenerarInstanciasAleatorias()
    {
       
        for (int i = 0; i < cantidadInstancias; i++)
        {
           
            int indiceX = Random.Range(0, plano.cantidadX);
            int indiceZ = Random.Range(0, plano.cantidadZ);

           
            Vector3 posicion = plano.origen + new Vector3(indiceX * plano.espacioX, 0f, indiceZ * plano.espacioZ);

            
            GameObject prefabAleatorio = prefabs[Random.Range(0, prefabs.Length)];
            Instantiate(prefabAleatorio, posicion, Quaternion.identity);
        }
    }
}
