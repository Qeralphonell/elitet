private float fallSpeed = 0.5f;

public void UpdateFallSpeed(float delta)
{
    fallSpeed += delta * 0.1f;
    if (fallSpeed > 5.0f)
    {
        fallSpeed = 5.0f;
    }
}
