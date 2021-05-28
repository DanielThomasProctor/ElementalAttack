 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu1()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Game()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Victory()
    {
        SceneManager.LoadScene("Victory");
    }
    public void Defeat1()
    {
        SceneManager.LoadScene("Defeat");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
