using UnityEngine;
using UnityEngine.Audio;

public class SoundSetting : MonoBehaviour
{
    private const string Master = "Master";
    private const string Button = "Button";
    private const string Background = "Background";
    private const string MusicEnabled = "MusicEnabled";
    private const string TotalVolume = "TotalVolume";

    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private bool _isOffSound = false;
    private float _minVolue = 0.001f;
    private float _maxVolue = 1f;

    public void ToggleMusic()
    {
        if (_isOffSound)
            ChangeVolume(Master, _maxVolue);
        else
            ChangeVolume(Master, _minVolue);

        _isOffSound = !_isOffSound;

        PlayerPrefs.SetInt(MusicEnabled, _isOffSound ? 1 : 0);
    }

    public void ChangeTotalVolume(float value)
    {
        if (_isOffSound)
        {
            _isOffSound = !_isOffSound;
            PlayerPrefs.SetInt(MusicEnabled, _isOffSound ? 1 : 0);
        }

        ChangeVolume(Master, value);
        PlayerPrefs.SetFloat(TotalVolume, value);
    }

    public void ChangeButtonVolume(float value)
    {
        ChangeVolume(Button, value);
    }

    public void ChangeBackgroundVolume(float value)
    {
        ChangeVolume(Background, value);
    }

    private void ChangeVolume(string name, float value)
    {
        _audioMixerGroup.audioMixer.SetFloat(name, Mathf.Log10(value) * 20);
    }
}
