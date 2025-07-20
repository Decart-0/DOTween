using UnityEngine;
using DG.Tweening;

public class Resizing : MonoBehaviour
{
    [SerializeField] private int _repeats;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType = Ease.Linear;
    [SerializeField] private Vector3 _targetScale = new Vector3(2f, 2f, 2f);

    private void Start()
    {
        transform.DOScale(_targetScale, _duration).SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}