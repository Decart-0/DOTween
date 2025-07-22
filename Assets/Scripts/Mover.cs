using UnityEngine;
using DG.Tweening;

public class Mover : BaseDOTween
{
    [SerializeField] private Vector3 _position;

    private void Start()
    {
        transform.DOMove(_position, Duration).SetLoops(Repeats, LoopType).SetEase(EaseType);    
    }
}