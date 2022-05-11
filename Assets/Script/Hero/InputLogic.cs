using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLogic : MonoBehaviour
{
    //Изменяемы параметры
    [SerializeField] private static float _speedInput = 5;
    //Ссылки на компоненты 
    private Animator _animator;
    private Rigidbody _rigidbody;
    //Направления
    private Vector3 direction_W = new Vector3(0,0,0.5f);
    private Vector3 direction_S = new Vector3(0, 0, -0.5f);
    private Vector3 direction_A = new Vector3(-2, 0, 0);
    private Vector3 direction_D = new Vector3(2, 0, 0);

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        Input_A();
        Input_D();
        Input_S();
        Input_W();
    }
    private void Input_W()
    {
        if(Input.GetKey(KeyCode.W))
        {
            _animator.SetBool("D_W", true);
            transform.Translate(direction_W * _speedInput * Time.deltaTime);
        }
        else
        {
            _animator.SetBool("D_W", false);
        }
    }
    private void Input_S()
    {
        if(Input.GetKey(KeyCode.S))
        {
            _animator.SetBool("D_S", true);
            transform.Translate(direction_S * _speedInput * Time.deltaTime);
        }
        else
        {
            _animator.SetBool("D_S", false);
        }
    }
    private void Input_A()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _animator.SetBool("D_A", true);
            transform.Translate(direction_A * _speedInput * Time.deltaTime);
        }
        else
        {
            _animator.SetBool("D_A", false);
        }
    }
    private void Input_D()
    {
        if(Input.GetKey(KeyCode.D))
        {
            _animator.SetBool("D_D", true);
            transform.Translate(direction_D * _speedInput * Time.deltaTime);
        }
        else
        {
            _animator.SetBool("D_D", false);
        }
    }
}
