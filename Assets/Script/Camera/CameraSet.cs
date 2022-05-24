using UnityEngine;

public class CameraSet : MonoBehaviour
{
    [SerializeField] private Transform _targetHero;
    [SerializeField] private float offset;
    private void Update()
    {
        transform.position = new Vector3(_targetHero.position.x, _targetHero.position.y + offset, transform.position.z);
    }
}
