using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _targetHero;
    private void Update()
    {
        transform.position = new Vector3(_targetHero.position.x, transform.position.y, transform.position.z);
    }
}
