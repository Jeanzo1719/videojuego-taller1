using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destruye objetos que salen de los límites definidos del escenario.
/// </summary>
public class DestroyOutOfBoundsX : MonoBehaviour
{
    // Límite izquierdo del escenario
    private float leftLimit = 30;

    // Límite inferior del escenario
    private float bottomLimit = -5;

    /// <summary>
    /// Se ejecuta cada frame.
    /// Verifica si el objeto salió de los límites.
    /// </summary>
    void Update()
    {
        // Si el objeto (perro) sale por la izquierda
        if (transform.position.x < -leftLimit)
        {
            Destroy(gameObject);
        } 
        // Si el objeto (bola) cae por debajo del límite inferior
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}