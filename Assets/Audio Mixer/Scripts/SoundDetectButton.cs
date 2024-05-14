using TMPro;
using UnityEngine;

public class SoundDetectButton : MonoBehaviour
{
    private const string SoundOn = "«‚ÛÍ ¬ À";
    private const string SoundOff = "«‚ÛÍ ¬€ À";

    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private SoundSetting _soundSetting;

    private void OnEnable()
    {
        _soundSetting.MusicEnabled += ChangeTextInBottun;
    }

    private void OnDisable()
    {
        _soundSetting.MusicEnabled -= ChangeTextInBottun;
    }

    private void ChangeTextInBottun(bool musicEnabled)
    {
        if (musicEnabled)
            _text.text = SoundOff;
        else
            _text.text = SoundOn;
    }
}
