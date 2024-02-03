using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject messageBox;

    [SerializeField] private int amountKeyActivate;

    [SerializeField] private UnityEvent Enter;

    private bool Activated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (Activated) return;

        Bag bag = other.GetComponent<Bag>();

        if (bag != null)
        {
            if (bag.DrawKey(amountKeyActivate) == true)
            {
                Enter.Invoke();
                Activated = true;
            }
            else
            {
                messageBox.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        messageBox.SetActive(false);
    }
}
