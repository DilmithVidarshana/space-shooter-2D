using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   public void playGame()
   {
	   Time.timeScale = 1;
	   SceneManager.LoadScene(0);
   }
   public void quitDeskTop()
   {
	   Application.Quit();
   }
   public void Restart()
   {
	   Time.timeScale = 1;
	   SceneManager.LoadScene(0);
   }
   public void Quik()
   {
	   SceneManager.LoadScene(1);
   }
}
