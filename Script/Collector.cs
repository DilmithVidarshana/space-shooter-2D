using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{

[SerializeField]private Text _scoreText;
[SerializeField]private int _score = 0;
    [SerializeField] private GameObject _gameOverPannel;

    // Start is called before the first frame update
    private void OnTriggerEnter2D (Collider2D target)
    {
        if(target.tag == "Astro")
        {
            UpdateScore();
           target.gameObject.SetActive(false);
        }
         if(target.tag == "Enamy")
        {
           
            _gameOverPannel.SetActive(true);
            Time.timeScale = 0;
    
        }
    }

  private void UpdateScore()
  {
      _score++;
      _scoreText.text = "Score :" + _score.ToString();
  }
    
}
