using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class CamaraSeguimiento : MonoBehaviour
{
    public Transform objetivo; // El robot
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Altura y distancia detr�s del robot
    public float suavizado = 5f;

    void LateUpdate()
    {
        if (objetivo != null)
        {
            // Calcula la posici�n deseada de la c�mara en funci�n del robot + offset
            Vector3 posicionDeseada = objetivo.position + objetivo.TransformDirection(offset);

            // Desplaza suavemente la c�mara a esa posici�n
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
