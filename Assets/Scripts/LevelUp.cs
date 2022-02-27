using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    public Text pointText;
    
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointText.text = score.ToString() +" Points";
    }

    public void TwoLevelButton()
    {
        SceneManager.LoadScene("Level2");
    }
    public void ThreeLevelButton()
    {
        SceneManager.LoadScene("Level3");
    }
    public void FourLevelButton()
    {
        SceneManager.LoadScene("Level4");
    }
    public void FiveLevelButton()
    {
        SceneManager.LoadScene("Level5");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
