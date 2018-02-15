using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public void QuitApplication()
    {
        Application.Quit();
    }

    public void LoadNextScene(int level)
    {
        Application.LoadLevel(level);
    }
}
