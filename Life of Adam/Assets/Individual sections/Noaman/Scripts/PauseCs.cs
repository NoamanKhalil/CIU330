using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCs : MonoBehaviour
{
     void Start()
    {
        OnPlay();
    }

    public void OnPause()
	{
		Time.timeScale = 0;
		Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
	public void OnPlay()
	{
		Time.timeScale = 1;
		Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
