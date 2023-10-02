using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startscreen : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene(1);
    }
    public void died()
    {
        SceneManager.LoadScene(1);
    }
}
