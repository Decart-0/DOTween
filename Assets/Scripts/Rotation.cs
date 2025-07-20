using UnityEngine;
using DG.Tweening;

public class Rotation : MonoBehaviour
{
    [SerializeField] private int _repeats;
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _rotation = new Vector3(0, 360f, 0);
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType = Ease.Linear;
    [SerializeField] private RotateMode _rotateMode = RotateMode.LocalAxisAdd;

    private void Start()
    {
        transform.DORotate(_rotation, _duration, _rotateMode).SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}