using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using SimpleFPS;

public class PauseChecker : MonoBehaviour
{
    public UnityEvent Escape;
    public UnityEvent UnEscape;

    public static bool GameIsPaused = false;
    public FirstPersonController fps;
    public MouseLook fpsmouse;

    private void Start()
    {
        Resume();
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        fps.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        fpsmouse.lockCursor = true;
        fps.m_MouseLook.UpdateCursorLock();
        fpsmouse.CIL();
        UnEscape.Invoke();
    }
    private void Pause()
    {
        Time.timeScale = 0f;
        fpsmouse.lockCursor = false;
        Cursor.visible = true;
        GameIsPaused = true;
        fps.enabled = false;
        fps.m_MouseLook.UpdateCursorLock();
        Escape.Invoke();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (GameIsPaused == false)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

}
