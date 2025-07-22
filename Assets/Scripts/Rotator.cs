using UnityEngine;
using DG.Tweening;

public class Rotator : BaseDOTween
{
    [SerializeField] private Vector3 _rotation = new Vector3(0, 360f, 0);
    [SerializeField] private RotateMode _rotateMode = RotateMode.LocalAxisAdd;

    private void Start()
    {
        transform.DORotate(_rotation, Duration, _rotateMode).SetLoops(Repeats, LoopType).SetEase(EaseType);
    }
}