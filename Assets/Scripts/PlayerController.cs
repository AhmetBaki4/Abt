using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private Object1 _object1;
    private float _playerSpeed = 15f;
    float _inputHoriontal;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _object1.SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        _inputHoriontal = Input.GetAxisRaw("Horizontal");

        if (_inputHoriontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHoriontal * _playerSpeed, 0f));
        }
    }
}
