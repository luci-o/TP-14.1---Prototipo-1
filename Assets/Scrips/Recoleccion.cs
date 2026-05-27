using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Recoleccion : MonoBehaviour
{
    private int objetosRecolectados = 0;
    public TextMeshProUGUI textoUI;
    
    void Start()
    {
        textoUI.text = "0";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            objetosRecolectados++;

            // Actualiza solo el número
            textoUI.text = objetosRecolectados.ToString();

            Debug.Log("Objeto destruido correctamente");
            Destroy(other.gameObject);
        }
    }
}