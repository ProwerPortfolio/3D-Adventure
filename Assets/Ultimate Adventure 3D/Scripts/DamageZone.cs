using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float damageRate;

    private Destructible destructible;

    private float timer;

    private void Start()
    {
        enabled = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        
        if (timer >= damageRate)
        {
            destructible.ApplyDamage(damage);

            timer = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        destructible = other.GetComponent<Destructible>();

        if (destructible != null)
        {
            enabled = true;
            timer = damageRate;
        }
    }

    private void OnTriggerExit(Collider other)
    {
       if (other.GetComponent<Destructible>() == destructible)
        {
            destructible = null;

            enabled = false;
        }
    }
}
