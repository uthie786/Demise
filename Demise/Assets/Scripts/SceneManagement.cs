using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] private AudioSource clickButton;
    public void ChangeScene(int sceneID)
    {
        clickButton.Play();
        SceneManager.LoadScene(sceneID);
    }
}
