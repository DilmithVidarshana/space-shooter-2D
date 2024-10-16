using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroSpowner : MonoBehaviour
{
    [SerializeField]private GameObject _astroPrefeb;
    private float _minX = -7.01f;
    private float _maxX = 6.88f;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(spowanAstro());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator spowanAstro()
        {
            yield return new WaitForSeconds(Random.Range(0f,1.2f));
            Instantiate(_astroPrefeb,new Vector2(Random.Range(_minX,_maxX),transform.position.y),
            Quaternion.identity);

            StartCoroutine(spowanAstro());
        }
    
}
