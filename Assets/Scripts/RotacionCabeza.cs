using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class RotacionCabeza : MonoBehaviour
{
    public float velocidadRotacion = 100f;

    void Update()
    {
        float rotacion = 0f;

        if (Input.GetKey(KeyCode.Q))
        {
            rotacion = -1f;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotacion = 1f;
        }

        transform.Rotate(0f, rotacion * velocidadRotacion * Time.deltaTime, 0f);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
