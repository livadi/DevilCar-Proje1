using UnityEngine.Audio;
using UnityEngine;


public class audiosc : MonoBehaviour
{
    public static AudioClip death1, death2, death3, death4, death5, death6, death7, death8, death9, death10,rock2, rock3,rock4, rock1, rockstart1,boots, boots2, boots3,cash,music,totem,paper,spy,human,button;
    public static bool isMute;
    static AudioSource audioSource;
     void Start()
    {
        spy = Resources.Load<AudioClip>("spy");
        human = Resources.Load<AudioClip>("human");
        button = Resources.Load<AudioClip>("button");
        paper = Resources.Load<AudioClip>("paper");
        death1 = Resources.Load<AudioClip>("death1");
        death2 = Resources.Load<AudioClip>("death2");
        death10 = Resources.Load<AudioClip>("death10");
        death3 = Resources.Load<AudioClip>("death3");
        death4 = Resources.Load<AudioClip>("death4");
        death5 = Resources.Load<AudioClip>("death5");
        death6 = Resources.Load<AudioClip>("death6");
        death7 = Resources.Load<AudioClip>("death7");
        death8 = Resources.Load<AudioClip>("death8");
        death9 = Resources.Load<AudioClip>("death9");
        rock1 = Resources.Load<AudioClip>("rock1");
        rockstart1 = Resources.Load<AudioClip>("rockstart1");
        rock2 = Resources.Load<AudioClip>("rock2");
        rock3 = Resources.Load<AudioClip>("rock3");
        rock4 = Resources.Load<AudioClip>("rock4");
        music = Resources.Load<AudioClip>("music");
        cash = Resources.Load<AudioClip>("cash");
        boots = Resources.Load<AudioClip>("boots");
        boots2 = Resources.Load<AudioClip>("boots2");
        boots3 = Resources.Load<AudioClip>("boots3");
        totem = Resources.Load<AudioClip>("totem");
        audioSource = GetComponent<AudioSource>();
       
    }
    

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "death2":
                audioSource.PlayOneShot(death2);
                break;
            case "death10":
                audioSource.PlayOneShot(death10);
                break;
            case "death1":
                audioSource.PlayOneShot(death1);
                break;
            case "death3":
                audioSource.PlayOneShot(death3);
                break;
            case "death4":
                audioSource.PlayOneShot(death4);
                break;
            case "death5":
                audioSource.PlayOneShot(death5);
                break;
                case "death6":
                audioSource.PlayOneShot(death6);
                break;
                case "death7":
                audioSource.PlayOneShot(death7);
                break;
                case "death8":
                audioSource.PlayOneShot(death8);
                break;
                case "death9":
                audioSource.PlayOneShot(death9);
                break;
                case "rock2":
                audioSource.PlayOneShot(rock2);
                break;
                case "rock3":
                audioSource.PlayOneShot(rock3);
                break;
            case "rock4":
                audioSource.PlayOneShot(rock4);
                break;
            case "music":
                audioSource.PlayOneShot(music);
                break;

            case "cash":
                audioSource.PlayOneShot(cash);
                break;
            case "rockstart1":
                audioSource.PlayOneShot(rockstart1);
                break;
            case "rock1":
                audioSource.PlayOneShot(rock1);
                break;
            case "boots":
                audioSource.PlayOneShot(boots);
                break;
            case "boots2":
                audioSource.PlayOneShot(boots2);
                break;
            case "boots3":
                audioSource.PlayOneShot(boots3);
                break;
            case "totem":
                audioSource.PlayOneShot(totem);
                break;
            case "paper":
                audioSource.PlayOneShot(paper);
                break;
            case "human":
                audioSource.PlayOneShot(human);
                break;
            case "spy":
                audioSource.PlayOneShot(spy);
                break;
            case "button":
                audioSource.PlayOneShot(button);
                break;

        }
    }
}
