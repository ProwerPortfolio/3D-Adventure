using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MessageLifeTimeFinal : MessageLifeTime
{

    public override void Start()
    {
        base.Start();
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene(0);
    }
}
