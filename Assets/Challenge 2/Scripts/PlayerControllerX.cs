using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controla la entrada del jugador.
/// Permite generar (instanciar) un perro al presionar la barra espaciadora.
/// </summary>
public class PlayerControllerX : MonoBehaviour
{
    // Prefab del perro que será instanciado
    public GameObject dogPrefab;

    /// <summary>
    /// Se ejecuta cada frame.
    /// Detecta la entrada del usuario.
    /// </summary>
    void Update()
    {
        // Si se presiona la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instancia un perro en la posición actual del jugador
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}