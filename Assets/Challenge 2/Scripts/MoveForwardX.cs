using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Mueve un objeto constantemente hacia adelante.
/// </summary>
public class MoveForwardX : MonoBehaviour
{
    // Velocidad de movimiento
    public float speed;

    /// <summary>
    /// Se ejecuta cada frame.
    /// Aplica movimiento continuo al objeto.
    /// </summary>
    void Update()
    {
        // Mueve el objeto en la dirección forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}