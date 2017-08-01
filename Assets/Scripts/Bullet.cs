using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _bulletHolder;
    private float _bulletSpeed;
    private GameObject _clone;


    private void Start()
    {
        _bulletSpeed = 500f;
    }

    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            _clone = Instantiate(_bullet, _bulletHolder.transform.position, _bullet.transform.rotation);
            _clone.GetComponent<Rigidbody>().AddForce(_clone.transform.forward * _bulletSpeed);
        }
    }

}
