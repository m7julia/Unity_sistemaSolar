using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip musicClip;
    private AudioSource musicSource;

    // Referência ao gerenciador de música
    private static MusicPlayer currentMusicPlayer;

    void Start()
    {
        // Adiciona um componente AudioSource ao objeto
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = musicClip;
    }

    void OnMouseDown()
    {
        // Verifica se o botão do mouse foi clicado
        if (Input.GetMouseButtonDown(0))
        {
            // Verifica se já há um MusicPlayer em execução
            if (currentMusicPlayer != null)
            {
                // Para a música no MusicPlayer existente
                currentMusicPlayer.StopMusic();
            }

            // Define o MusicPlayer atual como este
            currentMusicPlayer = this;

            // Toca a música
            musicSource.Play();
        }
    }

    // Método para parar a música
    private void StopMusic()
    {
        if (musicSource.isPlaying)
        {
            musicSource.Stop();
        }
    }
}