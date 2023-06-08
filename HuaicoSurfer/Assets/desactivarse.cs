using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivarse : MonoBehaviour
{
    public int TiempoDesactivacion = 6;
    private void Start()
    {
        // Llama a la funci�n Desactivar() despu�s de 6 segundos
        Invoke("Desactivar", TiempoDesactivacion);
    }

    private void Desactivar()
    {
        // Desactiva el objeto al que est� adherido este script
        gameObject.SetActive(false);
    }
}
