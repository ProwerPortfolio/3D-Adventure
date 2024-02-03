using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destructible distructible = other.GetComponent<Destructible>();

        if (distructible != null)
        {
            distructible.Kill();
        }
    }
}
