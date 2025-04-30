using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    public float speed = 4f;
    public int health = 10;
    LevelManager lm;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        lm = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }

    private void FixedUpdate()
    {
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.CompareTag("PlayerWeapon"))
        {
            Weapon weapon = colision.GetComponent<Weapon>();
            if (weapon != null)
            {
                health -= weapon.damage; 
                if (health <= 0)
                {
                    lm.AddPoints(1); 
                    Destroy(gameObject);
                }
            }
        }
    }
}