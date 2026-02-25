using UnityEngine;

public class PlayerHealth : Health
{
    // Kéo thả Object Canvas Game Over vào ô này trong Inspector
    public GameObject gameOverCanvas;

    protected override void Die()
    {
        // Gọi logic chết cơ bản (tạo hiệu ứng nổ, xóa object) từ class cha
        base.Die();

        // Bật Canvas Game Over lên
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }

        // Tạm dừng thời gian trong game (tùy chọn)
        Time.timeScale = 0f;

        Debug.Log("Player died and Game Over screen shown");
    }
}