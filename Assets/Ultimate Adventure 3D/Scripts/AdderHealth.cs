using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdderHealth : MonoBehaviour
{
    [SerializeField] private int health;

    private void OnTriggerEnter(Collider other)
    {
        Destructible destructible = other.GetComponent<Destructible>();

        if (destructible != null)
        {
            destructible.AddHitPoints(health);
        }
    }
}
