using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType = Ease.Linear;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(_repeats, _loopType).SetEase(_easeType);    
    }
}