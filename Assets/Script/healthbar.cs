using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    [SerializeField]
    private Image fillImage;

    [SerializeField]
    private Gradient gradient;

    [SerializeField]
    private IntVariable playerCurrentLifePoints;

    [SerializeField]
    private IntVariable playerMaxLifePoints;

    void Update()
    {
        SetHealth();
    }

    private void SetHealth()
    {
        float healthNormalized = (float)playerCurrentLifePoints.CurrentValue / playerMaxLifePoints.CurrentValue;
        fillImage.fillAmount = healthNormalized;
        fillImage.color = gradient.Evaluate(healthNormalized);
    }
    
}
