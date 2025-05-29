using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Recolector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Recolectable"))
        {
            Destroy(other.gameObject);
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
