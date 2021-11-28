using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad : MonoBehaviour
{
    public string _LevelToLoad;
    // Start is called before the first frame update
    public void LoadLevel()
    {
        SceneManager.LoadScene(_LevelToLoad);
    }
}
