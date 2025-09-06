using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public static bool gameOver = false;
    public Image hpGauge;
    public Text gameOverText;
    
    public void DecreaseHp()
    {
        hpGauge.fillAmount -= 0.1f;

        if (hpGauge.fillAmount < 0.01f)
        {
            gameOver = true;
            gameOverText.text = "Game Over";
            Time.timeScale = 0;
        }
    }


}
