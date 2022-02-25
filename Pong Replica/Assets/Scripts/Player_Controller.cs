using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private Ball_Controller _ball;
    void Update()
    {
        var _mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            transform.position.y,
            transform.position.z
        ));

        _mousePos.x = Mathf.Clamp(_mousePos.x, -1.95f, 1.95f);

        transform.position = new Vector3(
            _mousePos.x,
            transform.position.y,
            transform.position.z
        );
    }
}
