using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject creditCanvas;
    [SerializeField] private GameObject helpCanvas;
    [SerializeField] private GameObject mainCanvas;

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
    public void CreditButton()
    {
        creditCanvas.SetActive(true);
        mainCanvas.SetActive(false);
    }
    public void HelpButton()
    {
        helpCanvas.SetActive(true);
        mainCanvas.SetActive(false);
    }
    public void ReturnButton()
    {
        helpCanvas.SetActive(false);
        creditCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

}
