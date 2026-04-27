# 🎮 Taller Unity – Juego de “Buscar”

Este proyecto corresponde a un taller práctico en Unity donde se implementa un juego simple basado en la generación de objetos aleatorios, detección de colisiones y control del jugador.

---

## 📌 Descripción

El objetivo del juego es **lanzar perros** para destruir **bolas que caen desde la parte superior de la pantalla**.

El proyecto demuestra el uso de:

* Arrays de prefabs
* Generación aleatoria
* Física básica (movimiento y colisiones)
* Lógica de juego en Unity

---

## 🧠 Mecánicas del juego

* Las **bolas** aparecen aleatoriamente en la parte superior
* El jugador puede lanzar **perros** presionando la barra espaciadora
* Las bolas se destruyen **solo al colisionar con un perro**
* Los objetos se eliminan al salir de los límites del escenario

---

## 🎮 Controles

| Acción       | Tecla   |
| ------------ | ------- |
| Lanzar perro | Espacio |

---

## ⚙️ Tecnologías utilizadas

* Unity (3D)
* C#
* Sistema de físicas de Unity (Rigidbody + Colliders)

---

## 🗂️ Estructura del proyecto

* `SpawnManagerX` → Genera bolas aleatorias
* `PlayerControllerX` → Controla la entrada del jugador
* `MoveForwardX` → Movimiento de objetos
* `DetectCollisionsX` → Manejo de colisiones
* `DestroyOutOfBoundsX` → Eliminación de objetos fuera de límites

---

## 🧪 Conceptos aplicados

* Uso de `Random.Range()` para valores aleatorios
* Uso de arrays (`GameObject[]`)
* Instanciación dinámica (`Instantiate`)
* Detección de colisiones (`OnTriggerEnter` / `OnCollisionEnter`)
* Control de flujo en `Update()`

---

## ⚠️ Notas importantes

* Es necesario que los objetos tengan correctamente configurados:

  * `Collider`
  * `Rigidbody`
  * Tags (ej: `"Dog"`)
* Se debe evitar el uso de escalas excesivas en los prefabs para no afectar los colliders
* Los archivos grandes (videos, assets) se manejan con **Git LFS**

---

## 🚀 Cómo ejecutar

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/Jeanzo1719/videojuego-taller1.git
   ```

2. Abrir el proyecto en Unity Hub

3. Ejecutar la escena principal

---

## 📹 Demo

[Ver video](./demo.mp4)

---

## 📄 Licencia

Este proyecto es únicamente con fines educativos.
