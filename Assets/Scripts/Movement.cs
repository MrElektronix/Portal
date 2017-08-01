using UnityEngine;

public class Movement : MonoBehaviour
{
    private const float Speed = 5f;
    [SerializeField] private GameObject _gameObject;

    private void FixedUpdate()
    {
        var x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Speed;
        var z = Input.GetAxisRaw("Vertical") * Time.deltaTime * Speed;

        _gameObject.transform.Translate(x, 0f, z);
    }

}
