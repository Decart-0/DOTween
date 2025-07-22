using UnityEngine;
using DG.Tweening;

public class Resizer : BaseDOTween
{
    [SerializeField] private Vector3 _targetScale = new Vector3(2f, 2f, 2f);

    private void Start()
    {
        transform.DOScale(_targetScale, Duration).SetLoops(Repeats, LoopType).SetEase(EaseType);
    }
}