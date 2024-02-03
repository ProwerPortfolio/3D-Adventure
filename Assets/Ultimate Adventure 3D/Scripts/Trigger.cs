using UnityEngine;
using UnityEngine.Events;
using SimpleFPS;

public class Trigger : MonoBehaviour
{
    public UnityEvent Enter;
    public UnityEvent Exit;

    public void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            Enter.Invoke();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            Exit.Invoke();
        }
    }
}
