using UnityEngine;

public abstract class Animal : LivingGameEntity
{
    [SerializeField]
    protected AudioClip talkSound;

    public virtual void Talk()
    {
        soundSource.clip = talkSound;
        soundSource.Play();
    }

    private string animalName;

    public string AnimalName
    {
        get
        {
            return animalName;
        }
        protected set
        {
            if (value.Length < 20)
            {
                animalName = value;
            }
        }
    }
}
