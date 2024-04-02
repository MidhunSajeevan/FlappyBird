using UnityEngine;

public class FlyLittleBirdy : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private float Velocity = 1f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = Vector2.up * Velocity;
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.OnGameOver?.Invoke();
    }

}
