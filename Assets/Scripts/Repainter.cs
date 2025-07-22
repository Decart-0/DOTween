using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Repainter : BaseDOTween
{
    [SerializeField] private Color _color;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _renderer.material.DOColor(_color, Duration).SetLoops(Repeats, LoopType).SetEase(EaseType);
    }
}