using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Gestiona la generación de bolas en posiciones aleatorias.
/// </summary>
public class SpawnManagerX : MonoBehaviour
{
    // Array de prefabs de bolas
    public GameObject[] ballPrefabs;

    // Límites horizontales de aparición
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;

    // Posición vertical fija donde aparecen las bolas
    private float spawnPosY = 30;

    // Tiempo inicial antes del primer spawn
    private float startDelay = 1.0f;

    // Intervalo entre spawns
    private float spawnInterval = 4.0f;

    /// <summary>
    /// Se ejecuta al iniciar el juego.
    /// Configura la generación repetida de bolas.
    /// </summary>
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    /// <summary>
    /// Genera una bola aleatoria en una posición aleatoria.
    /// </summary>
    void SpawnRandomBall ()
    {
        // Selecciona un índice aleatorio del array
        int i = Random.Range(0, ballPrefabs.Length);

        // Genera una posición aleatoria en el eje X
        Vector3 spawnPos = new Vector3(
            Random.Range(spawnLimitXLeft, spawnLimitXRight),
            spawnPosY,
            0
        );

        // Instancia la bola seleccionada en la posición generada
        Instantiate(ballPrefabs[i], spawnPos, ballPrefabs[i].transform.rotation);
    }
}