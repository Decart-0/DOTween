using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangerText : BaseDOTween
{
    private const string SatrtText = "����� ��� ���������";
    private const string AddedText = " ����������� �����";
    private const string ReplacedText = "� ������� �����";
    private const string OverriddenText = "����������� �����";

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