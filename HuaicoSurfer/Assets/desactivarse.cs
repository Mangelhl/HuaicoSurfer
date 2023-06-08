using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivarse : MonoBehaviour
{
    public int TiempoDesactivacion = 6;
    private void Start()
    {
        // Llama a la función Desactivar() después de 6 segundos
        Invoke("Desactivar", TiempoDesactivacion);
    }

    private void Desactivar()
    {
        // Desactiva el objeto al que está adherido este script
        gameObject.SetActive(false);
    }
}
