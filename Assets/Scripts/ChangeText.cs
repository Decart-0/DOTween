using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    private const string SatrtText = "����� ��� ���������";
    private const string AddedText = " ����������� �����";
    private const string ReplacedText = "� ������� �����";
    private const string OverriddenText = "����������� �����";

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