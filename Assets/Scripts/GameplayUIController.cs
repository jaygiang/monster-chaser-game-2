using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{
    public void GameplayButtons()
    {
        string selectedRestart = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        
        if (selectedRestart == "Restart")
        {
            SceneManager.LoadScene("Gameplay");
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
