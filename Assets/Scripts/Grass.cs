using UnityEngine;

public class Grass : MonoBehaviour
{
    [SerializeField]
    private float _regrowDuration = 3f;

    [SerializeField]
    private Animator _animator;

    public bool IsAvailable { get; private set; } = true;

    public void GetEaten()
    {
        if (!IsAvailable)
        {
            return;
        }

        IsAvailable = false;
        _animator.SetTrigger("Disappear");
        Invoke(nameof(Regrow), _regrowDuration);
    }

    private void Regrow()
    {
        _animator.SetTrigger("Appear");
        IsAvailable = true;
    }
}
