using System;
using UnityEngine;

namespace Sound
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public void Play(AudioClip clip)
        {
            var setSound = SetSound();
            if (setSound != null)
            {
                setSound.PlaySound(clip);
            }
        }

        private IUseSound SetSound()
        {
            return gameObject.GetComponent<IUseSound>();
        }
    }
}
