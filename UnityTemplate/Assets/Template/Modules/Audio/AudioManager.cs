using System.Collections.Generic;
using System;
using UnityEngine;
using System.Collections;
using System.Linq;
using OurUtils;

namespace Template
{
    /// <summary>
    /// Store and manage audios need for a scene
    /// </summary>
    public class AudioManager : SingletonMono<AudioManager>
    {
        [Header("Data")]
        [SerializeField] private List<AudioData> _soundList = new();
        [SerializeField] private List<AudioData> _musicList = new();

        private AudioSource _musicAudioSource;


        #region Audio Setting
        const string KEY_VIBRATE = "VIBRATE";
        const string KEY_SOUND = "SOUND";
        const string KEY_MUSIC = "MUSIC";

        [Header("Audio Setting")]
        [SerializeField] private bool _isEnableSound;
        [SerializeField] private bool _isEnableMusic;
        [SerializeField] private bool _isEnableVibrate;

        [Range(0f, 1f)]
        [SerializeField] private float _masterVolume = 0.5f;
        [Range(0f, 1f)]
        [SerializeField] private float _soundVolume = 0.5f;
        [Range(0f, 1f)]
        [SerializeField] private float _musicVolume = 0.5f;
        public bool IsEnableSound
        {
            get
            {
                return _isEnableSound;
            }
            set
            {
                _isEnableSound = value;
                Save(KEY_SOUND, _isEnableSound);
            }
        }

        public bool IsEnableVibrate
        {
            get
            {
                return _isEnableVibrate;
            }
            set
            {
                _isEnableVibrate = value;
                Save(KEY_VIBRATE, _isEnableVibrate);
            }
        }

        public bool IsEnableMusic
        {
            get
            {
                return _isEnableMusic;
            }
            set
            {
                _isEnableMusic = value;
                Save(KEY_MUSIC, _isEnableMusic);
                _musicAudioSource.mute = !value;
                if (_musicAudioSource.mute)
                {
                    _musicAudioSource.Pause();
                }
                else
                {
                    _musicAudioSource.Play();
                }
            }
        }

        public float MasterVolume { get => _masterVolume; set => _masterVolume = value; }
        public float SoundVolume { get => _soundVolume; set => _soundVolume = value; }
        public float MusicVolume { get => _musicVolume; set => _musicVolume = value; }

        public void ToggleSfx()
        {
            IsEnableSound = !_isEnableSound;
        }

        public void ToggleMusic()
        {
            IsEnableMusic = !_isEnableMusic;
        }

        public void ToggleVibrate()
        {
            IsEnableVibrate = !_isEnableVibrate;
        }
        private void Save(string key, bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(key, value ? 1 : 0);
            UnityEngine.PlayerPrefs.Save();
        }

        private bool Load(string key, bool defaultValue)
        {
            var value = defaultValue;
            if (UnityEngine.PlayerPrefs.HasKey(key))
            {
                value = UnityEngine.PlayerPrefs.GetInt(key) != 0;
            }
            return value;
        }
        #endregion


        //private void LoadAudioList()
        //{
        //    foreach (AudioData audioData in audioDatas)
        //    {
        //        if (audioData.AudioSource == null)
        //        {
        //            audioData.AudioSource = gameObject.AddComponent<AudioSource>();
        //        }
        //        audioData.AudioSource.clip = audioData.Clip;
        //        audioData.AudioSource.volume = audioData.Volume;
        //        audioData.AudioName = audioData.Clip.name;
        //    }
        //}

        //public void PlayAudio(string audioName)
        //{
        //    var audioData = audioDatas.FirstOrDefault((audioData) => audioData.AudioName.Equals(audioName));
        //    if (audioData == null)
        //    {
        //        Debug.Log("Audio not found!");
        //        return;
        //    }
        //    if (audioData.AudioSource.clip.loadState == AudioDataLoadState.Loaded)
        //    {
        //        audioData.AudioSource.Play();
        //    }
        //    else
        //    {
        //        StartCoroutine(PlayAudioCoroutine(audioData));
        //    }
        //}

        //IEnumerator PlayAudioCoroutine(AudioData audioData)
        //{
        //    float delayLoadingTime = 0f;
        //    audioData.AudioSource.clip.LoadAudioData();
        //    while (!audioData.AudioSource.clip.loadState.Equals(AudioDataLoadState.Loaded))
        //    {
        //        if (delayLoadingTime > loadingTimeOut)
        //        {
        //            Debug.Log($"Can not load audio {audioData.AudioName}!");
        //            break;
        //        }
        //        else
        //        {
        //            yield return new WaitForSeconds(0.01f);
        //            delayLoadingTime += 0.01f;
        //            Debug.Log(audioData.AudioSource.clip.loadState + " |" + delayLoadingTime + " | " + loadingTimeOut);

        //        }
        //    }
        //    if (audioData.AudioSource.clip.loadState.Equals(AudioDataLoadState.Loaded))
        //    {
        //        audioData.AudioSource.Play();
        //        audioData.AudioSource.time = delayLoadingTime;
        //    }
        //}

        //public void StopAudio(AudioData audioData)
        //{
        //    try
        //    {
        //        audioData.AudioSource.Stop();
        //    }
        //    catch
        //    {
        //        Debug.Log($"Can not stop audio {audioData.AudioName}!");
        //    }
        //}

    }

    

    public static class AudioName
    {
        public const string TemplateAudioName = "TemplateAudioName";
    }
}