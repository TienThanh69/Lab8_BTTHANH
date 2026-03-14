using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Danh sách các loại Enemy (Kéo cả Fast và Strong vào đây)
    public GameObject[] enemyVariants;

    // Thời gian chờ giữa mỗi lần sinh quái
    public float spawnInterval = 2f;

    private float timer = 0f;

    void Update()
    {
        // Tăng thời gian đếm lên theo thời gian thực
        timer += Time.deltaTime;

        // Nếu thời gian đếm vượt quá khoảng chờ
        if (timer >= spawnInterval)
        {
            SpawnRandomEnemy();
            timer = 0f; // Reset lại đồng hồ
        }
    }

    void SpawnRandomEnemy()
    {
        // Kiểm tra xem đã kéo Prefab vào danh sách chưa
        if (enemyVariants.Length == 0) return;

        // Chọn ngẫu nhiên một con trong danh sách
        int randomIndex = Random.Range(0, enemyVariants.Length);

        // Sinh ra con quái đó tại vị trí Spawner
        Instantiate(enemyVariants[randomIndex], transform.position, Quaternion.identity);
    }
}