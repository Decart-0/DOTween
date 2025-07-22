using DG.Tweening;
using UnityEngine;

public class BaseDOTween : MonoBehaviour
{
    [SerializeField] protected int Repeats;
    [SerializeField] protected float Duration;
    [SerializeField] protected LoopType LoopType;
    [SerializeField] protected Ease EaseType = Ease.Linear;
}