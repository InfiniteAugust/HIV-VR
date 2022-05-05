using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public bool isAlive = true;
    public int Speed = 8;
    public AudioSource Audio;
    public AudioClip DamageAudio;
    public AudioClip DeathAudio;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ApplyDamage(int amount) 
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);
        Audio.clip = DamageAudio;
        Audio.Play();

        if (currentHealth <= 0)
        {
            Audio.clip = DeathAudio;
            Audio.Play();
            //Destroy(gameObject);
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            //Debug.Log("Mesh disabl..");
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                Invoke("change", 4f);
            }

        }
        //Debug.Log(gameObject.name + currentHealth);
        


       

    }
    public void change()
    {

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}
