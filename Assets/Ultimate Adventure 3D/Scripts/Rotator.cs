using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Transform native;
    [SerializeField] private Vector3 speed;

    private void Update()
    {
        native.Rotate(speed * Time.deltaTime);
    }
}
