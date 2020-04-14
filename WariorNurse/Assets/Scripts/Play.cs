using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject Message;
    public GameObject GameOver;

    public void PlayGame()
    {
                SceneManager.LoadScene("SampleScene");
    }

    public void EntryScene()
    {
        MenuPanel.SetActive(false);
        Message.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
