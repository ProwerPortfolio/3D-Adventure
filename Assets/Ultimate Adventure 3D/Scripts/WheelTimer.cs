using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WheelTimer : MonoBehaviour
{
    private bool buttonPess1 = false;
    private bool buttonPess2 = false;
    private bool buttonPess3 = false;
    [SerializeField] private float timer;
    private float tmpTimer;
    public UnityEvent Manager;
    public UnityEvent UnManager;
    public Material button1;
    public Material button2;
    public Material button3;

    // Start is called before the first frame update
    void Start()
    {
        tmpTimer = timer;
    }

    public void DownButton1()
    {
        buttonPess1 = true;
        button1.color = Color.green;

        enabled = true;
    }

    public void DownButton2()
    {
        buttonPess2 = true;
        button2.color = Color.green;

        enabled = true;
    }

    public void DownButton3()
    {
        buttonPess3 = true;
        button3.color = Color.green;

        enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        tmpTimer -= Time.deltaTime;

        if (tmpTimer <= 0)
        {
            buttonPess1 = false;
            buttonPess2 = false;
            buttonPess3 = false;
            button1.color = Color.red;
            button2.color = Color.red;
            button3.color = Color.red;
            UnManager.Invoke();
            tmpTimer = timer;

            enabled = false;
        }

        if (buttonPess1 && buttonPess2 && buttonPess3)
        {
            Manager.Invoke();
        }
    }
}
