using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class MovimientoRobot : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A/D o ←/→
        float vertical = Input.GetAxis("Vertical");     // W/S o ↑/↓

        Vector3 movimiento = new Vector3(horizontal, 0f, vertical);
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
