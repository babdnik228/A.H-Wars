using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLogic : MonoBehaviour
{
    public static InputLogic inputLogic_singolton;
    //Изменяемы параметры
     public  float _speedInput = 5;
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
        inputLogic_singolton = this;
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
        if(Input.GetKey(KeyCode.UpArrow))
        {
            _animator.SetBool("D_W", true);
            Vector3 posW = transform.position;
            posW.z += _speedInput * Time.deltaTime;
            transform.position = posW;
        }
        else
        {
            _animator.SetBool("D_W", false);
        }
    }
    private void Input_S()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            _animator.SetBool("D_S", true);
            Vector3 posS = transform.position;
            posS.z -= _speedInput * Time.deltaTime;
            transform.position = posS;
        }
        else
        {
            _animator.SetBool("D_S", false);
        }
    }
    private void Input_A()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _animator.SetBool("D_A", true);
            Vector3 posA = transform.position;
            posA.x -= _speedInput * Time.deltaTime;
            transform.position = posA;
        }
        else
        {
            _animator.SetBool("D_A", false);
        }
    }
    private void Input_D()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            _animator.SetBool("D_D", true);
            Vector3 posD = transform.position;
            posD.x += _speedInput * Time.deltaTime;
            transform.position = posD;
        }
        else
        {
            _animator.SetBool("D_D", false);
        }
    }
}
