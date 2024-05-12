using TMPro;
using UnityEngine;

public class SoundDetectButton : MonoBehaviour
{
    private const string MusicEnabled = "MusicEnabled";
    private const string SoundOn = "���� ���";
    private const string SoundOff = "���� ����";

    [SerializeField] private TextMeshProUGUI _text;

    private void FixedUpdate()
    {
        if (PlayerPrefs.GetInt(MusicEnabled) == 0)
            _text.text = SoundOn;
        else
            _text.text = SoundOff;
    }
}
