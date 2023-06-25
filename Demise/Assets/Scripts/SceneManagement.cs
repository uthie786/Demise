using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] private AudioSource clickButton;
    public void ChangeScene(int sceneID)
    {
        
        SceneManager.LoadScene(sceneID);
        clickButton.Play();
    }

    public void Exit()
    {
        Application.Quit();
    }
}
