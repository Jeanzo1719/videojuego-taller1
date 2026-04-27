using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detecta colisiones mediante triggers.
/// Se encarga de destruir la bola cuando entra en contacto con un perro.
/// </summary>
public class DetectCollisionsX : MonoBehaviour
{
    /// <summary>
    /// Se ejecuta cuando otro collider entra en este trigger.
    /// </summary>
    /// <param name="other">El objeto que colisiona con este collider</param>
    private void OnTriggerEnter(Collider other)
    {
        // Verifica que el objeto que entra tenga el tag "Dog"
        if (other.CompareTag("Dog"))
        {
            // Destruye la bola (este objeto)
            Destroy(gameObject);
        }
    }
}