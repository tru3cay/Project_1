using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WormHole : NAM_MonoBehaviour
{
    protected string sceneName = "GalaxyDemo";

    protected virtual void OnMouseDown()
    {
        this.LoadGalaxy();
    }

    protected virtual void LoadGalaxy()
    {
        SceneManager.LoadScene(this.sceneName);
    }
}
