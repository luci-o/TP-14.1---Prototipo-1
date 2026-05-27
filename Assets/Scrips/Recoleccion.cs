using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoleccion : MonoBehaviour
{
    // Variable para el contador
    private int objetosRecolectados = 0;

    // Se activa cuando la esfera toca al reloj
    private void OnTriggerEnter(Collider other)
    {
        // Si lo que tocamos tiene el Tag "Coleccionable"
        if (other.CompareTag("Coleccionable"))
        {
            // Sumamos punto
            objetosRecolectados++;

            // Mostramos en consola
            Debug.Log("Objetos recolectados: " + objetosRecolectados);

            // Destruimos el reloj
            Destroy(other.gameObject);
        }
    }
}