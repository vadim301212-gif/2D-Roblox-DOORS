using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    public void Settings()
    {
        SceneManager.LoadScene("Setting");
    }
    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void GameExit()
    {
        print("Выход из игры");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
