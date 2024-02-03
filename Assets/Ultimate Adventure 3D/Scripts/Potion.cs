using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Pickup
{
    [SerializeField] private GameObject impactEffect;

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        Instantiate(impactEffect);
    }
}
