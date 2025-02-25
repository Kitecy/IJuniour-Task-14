using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public const string Horizontal = nameof(Horizontal);

    public bool IsJump { get; private set; }
    public float XDirection { get; private set; }

    private void Update()
    {
        XDirection = Input.GetAxis(Horizontal);
        IsJump = Input.GetKeyDown(KeyCode.Space);
    }
}
