using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamySpowner : MonoBehaviour
{
    [SerializeField]private GameObject _enamySpowner;
    private float _minX = -7.01f;
    private float _maxX = 6.88f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpowanEnamy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator SpowanEnamy()
    {
        yield return new WaitForSeconds(Random.Range(0f,2.0f));
        Instantiate(_enamySpowner,new Vector2(Random.Range(_minX,_maxX),transform.position.y),Quaternion.identity);

        StartCoroutine(SpowanEnamy());
    }
}
