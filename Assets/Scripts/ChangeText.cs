using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    private const string SatrtText = "Текст для изменений";
    private const string AddedText = " добавленный текст";
    private const string ReplacedText = "Я заменил текст";
    private const string OverriddenText = "Перебранный текст";

    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;

    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType = Ease.Linear;
    [SerializeField] private ScrambleMode _scrambleMode = ScrambleMode.All;

    private void Awake()
    {
        _text.text = SatrtText;
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(_text.DOText(ReplacedText, _duration));
        sequence.Append(_text.DOText(AddedText, _duration).SetRelative());
        sequence.Append(_text.DOText(OverriddenText, _duration, true, _scrambleMode));
        sequence.SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}