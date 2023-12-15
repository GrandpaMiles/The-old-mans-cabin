using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript2 : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    GameObject textGameObject;
    int lives = 3;
   
    TextMeshProUGUI textComponent;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, -20, 0, ForceMode.VelocityChange);
        textComponent = textGameObject.GetComponent<TextMeshProUGUI>();
        {
           
        }
        
    }
    [SerializeField]
    float speed = 10;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
        if (transform.position.y < -10)
        {
            lives -= 1;
           
            transform.position = new Vector3(8.899244f, 11.3335f, 6);
        }
        string livesText = "Lives: " + lives;
        textComponent.text = livesText;
        if (lives == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
    
}
