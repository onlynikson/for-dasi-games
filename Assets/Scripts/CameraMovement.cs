using UnityEngine;
using DG.Tweening;


public class CameraMovement : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] private float speed;

    private Transform _camera;
    private Vector3 offset;

    private void Awake()
    {
        _camera = this.transform;

        offset = _camera.position - player.position;

    }


    private void Update()
    {
        Follow();
    }
    // Follow Function
    private void Follow()
    {
        _camera.DOMoveX(player.position.x + offset.x,  speed * Time.deltaTime);
        _camera.DOMoveZ(player.position.z + offset.z, speed * Time.deltaTime);
    }
}
