using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Repaint : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType = Ease.Linear;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _renderer.material.DOColor(_color, _duration).SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}