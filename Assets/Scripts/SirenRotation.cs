using UnityEngine;

/// Rota el pivote de las sirenas sobre su eje Y local.
/// Asignar ÚNICAMENTE al objeto Siren_Pivot.
public class SirenRotation : MonoBehaviour
{
    [Tooltip("Velocidad de giro en grados por segundo")]
    public float rotationSpeed = 300f;

    void Update()
    {
        // Time.deltaTime = segundos desde el frame anterior.
        // Grados/segundo × segundos = grados de este frame,
        // así gira igual a 30 FPS que a 144 FPS.
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
    }
}