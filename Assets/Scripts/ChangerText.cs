using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangerText : BaseDOTween
{
    private const string SatrtText = "Текст для изменений";
    private const string AddedText = " добавленный текст";
    private const string ReplacedText = "Я заменил текст";
    private const string OverriddenText = "Перебранный текст";

    [SerializeField] private Text _text;
    [SerializeField] private ScrambleMode _scrambleMode = ScrambleMode.All;

    private void Awake()
    {
        _text.text = SatrtText;
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(_text.DOText(ReplacedText, Duration));
        sequence.Append(_text.DOText(AddedText, Duration).SetRelative());
        sequence.Append(_text.DOText(OverriddenText, Duration, true, _scrambleMode));
        sequence.SetLoops(Repeats, LoopType).SetEase(EaseType);
    }
}