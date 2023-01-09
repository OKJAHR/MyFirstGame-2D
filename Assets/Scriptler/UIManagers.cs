using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagers : MonoBehaviour

{
    public static UIManagers Instance;
    public GameObject BaslangicPanel;
    public GameObject LevelComplatedPanel;
    public GameObject QuitPanel;


    private void Awake()
    {
        Instance = this;

    }
    public void StartButton()
    {
        SceneManager.LoadScene(1);
        BaslangicPanel.SetActive(false);
    }

    public void NextLevelButton()
    {
       //
       //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        CloseLevelComplatedPanel();
        // GameManager.instance.karpuzSayisi = 0;
        GameManager.instance.NextScene();


    }

    public void OpenLevelComplatedPanel()
    {
        LevelComplatedPanel.SetActive(true);
    }
    public void CloseLevelComplatedPanel()
    {
        LevelComplatedPanel.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();

    }

    public void OpenQuitPanel()
    {
        QuitPanel.SetActive(true);

    }
}
