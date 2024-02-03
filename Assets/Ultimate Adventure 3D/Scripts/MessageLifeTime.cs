using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageLifeTime : MonoBehaviour
{
    public int lifeTime;

    public virtual void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
