using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalyerShip : MonoBehaviour
{
    [SerializeField] private float _playerSpeed = 10.0f;
    [SerializeField] private GameObject _gameOverPannel;
    [SerializeField] private GameObject _missile;
     private float fireDelay =0.25f;
     private float coolDownTimer =0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _horizontalInput = Input.GetAxis("Horizontal");
        Vector2 _currentPosition = transform.position;
         


        if(_horizontalInput > 0)
        {
            _currentPosition.x += _playerSpeed * Time.deltaTime;
        }
        else if (_horizontalInput < 0)
        {
            _currentPosition.x -= _playerSpeed * Time.deltaTime;
        }
        if(_currentPosition.x > 6.90f)
        {
            _currentPosition.x = 6.90f;
        }
        if(_currentPosition.x < -7.03 )
        {
            _currentPosition.x = -7.03f;
        }
      
      
        transform.position = _currentPosition;
        PlayerShooter();
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Astro")
        {
            _gameOverPannel.SetActive(true);
            Time.timeScale = 0;
           
        }
    }
    private void PlayerShooter(){
        coolDownTimer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && coolDownTimer <= 0){
            coolDownTimer = fireDelay;

            Instantiate(_missile,transform.position, transform.rotation);
        }
    }
  
}
