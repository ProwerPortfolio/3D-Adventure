using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTo : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 target;

    private void Update()
    {
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(target), speed * Time.deltaTime);
    }
}
