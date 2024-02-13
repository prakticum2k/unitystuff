using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public float respawnTime = 3.0f;
    public float respawnInvulnerabilityTime = 3.0f;
    public int lives = 3;

    public void PlayerDied()
    {
        this.lives--;

        if (this.lives < 0)
        {
            GameOver();
        } else {
            Invoke(nameof(Respawn), this.respawnTime);
        }

    }

    private void Respawn()
    {
        
        this.player.transform.position = Vector3.zero;
        this.player.gameObject.layer = LayerMask.NameToLayer("Ignore Collision");
        this.player.gameObject.SetActive(true);
        
        Invoke(nameof(TurnOnCollision), this.respawnInvulnerabilityTime);
    }

    private void TurnOnCollision()
    {
        this.player.gameObject.layer = LayerMask.NameToLayer("Player");
    }

    private void GameOver()
    {

    }

}
