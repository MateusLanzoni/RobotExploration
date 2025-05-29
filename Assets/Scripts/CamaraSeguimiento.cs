using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class CamaraSeguimiento : MonoBehaviour
{
    public Transform objetivo; // El robot
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Altura y distancia detrás del robot
    public float suavizado = 5f;

    void LateUpdate()
    {
        if (objetivo != null)
        {
            // Calcula la posición deseada de la cámara en función del robot + offset
            Vector3 posicionDeseada = objetivo.position + objetivo.TransformDirection(offset);

            // Desplaza suavemente la cámara a esa posición
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);

            // Siempre mira al robot
            transform.LookAt(objetivo);
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
